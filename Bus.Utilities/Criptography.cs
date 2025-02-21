//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha          Autor       Requerimiento
//    1.0             06/09/2024     HVIDAL      REQ 2024-010468 IMAGENES DEL VUEMOTION
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Globalization;


namespace Bus.Utilities
{
    public class Criptography
    {
        #region CharactersKey
        /// <summary>
        ///     ''' Character string for the key /Cadena de caracteres para la clave
        ///     ''' </summary>
        private const string CharactersKey = "rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5"; // No se puede alterar la cantidad de caracteres.
        #endregion

        #region EncryptKey
        /// <summary>
        ///     ''' Chain for the encrypted key / Cadena para la clave encriptada.
        ///     ''' </summary>
        ///     ''' La clave debe ser de 8 caracteres.
        private const string EncryptKey = "csf3lipe";
        #endregion

        #region EncryptConectionString
        /// <summary>
        ///     ''' Función que devuelve la cadena de conexión o una cadena de texto encriptada.
        ///     ''' </summary>
        ///     ''' <param name="pConectionStringDecrypt">Enviar la cadena de conexión desencriptada.</param>
        ///     ''' <returns></returns>
        public static string EncryptConectionString(string pConectionStringDecrypt)
        {
            byte[] IV = ASCIIEncoding.ASCII.GetBytes(EncryptKey);
            byte[] EncryptionKey = Convert.FromBase64String(CharactersKey);
            byte[] buffer = Encoding.UTF8.GetBytes(pConectionStringDecrypt);
            //TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();            
            TripleDES des = TripleDES.Create();
            des.Key = EncryptionKey;
            des.IV = IV;

            return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length));
        }
        #endregion

        #region DecryptConectionString
        /// <summary>
        ///     ''' Función que devuelve la cadena de conexión o una cadena de texto desencriptada.
        ///     ''' </summary>
        ///     ''' <param name="pConectionStringEncrypt">Enviar la cadena de conexión encriptada.</param>
        ///     ''' <returns></returns>
        public static string DecryptConectionString(string pConectionStringEncrypt)
        {
            byte[] IV = ASCIIEncoding.ASCII.GetBytes(EncryptKey);
            byte[] EncryptionKey = Convert.FromBase64String(CharactersKey);
            byte[] buffer = Convert.FromBase64String(pConectionStringEncrypt);
            //TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            TripleDES des = TripleDES.Create();
            des.Key = EncryptionKey;
            des.IV = IV;

            return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length));
        }
        #endregion

        #region EncryptPasswordClinica
        /// <summary>
        ///     ''' Encripta la contraseña de los usuarios de las bases de datos (clinica, logistica, ...)
        ///     ''' </summary>
        ///     ''' <param name="Password">Enviar la contraseña que desea encriptar.</param>
        ///     ''' <returns></returns>
        public static string EncryptPasswordClinica(string Password)
        {
            string wCadenaEncriptada = "";

            char[] PswArray = Password.ToCharArray();
            for (int i = 1; i <= PswArray.Length; i++)
            {
                wCadenaEncriptada = wCadenaEncriptada + Convert.ToChar(((int)PswArray[i - 1] + 17 + (i - 1) * 2));
            }

            return wCadenaEncriptada;
        }
        #endregion

        public class SHA
        {
            public static string GenerateSHA256String(object inputString)
            {
                SHA256 sha256 = SHA256.Create();
                byte[] bytes = Encoding.UTF8.GetBytes((string)inputString);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i <= hash.Length - 1; i++)
                    stringBuilder.Append(hash[i].ToString("X2"));

                return stringBuilder.ToString();
            }

            public static string GenerateSHA512String(object inputString)
            {
                SHA512 sha512 = SHA512.Create();
                byte[] bytes = Encoding.UTF8.GetBytes((string)inputString);
                byte[] hash = sha512.ComputeHash(bytes);
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i <= hash.Length - 1; i++)
                    stringBuilder.Append(hash[i].ToString("X2"));

                return stringBuilder.ToString();
            }
        }


        /*Para cifrando de agenda medica del doctor*/
        private static byte[] xSecretIV = new byte[16] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
        private static string xEncryptKey = "1234";
        public static  string EncryptStringAES256(string pCadena)
        {
            SHA256 wSHA256 = SHA256.Create();
            byte[] wEncryptKey = wSHA256.ComputeHash(Encoding.ASCII.GetBytes(xEncryptKey));

            Aes wAESEncriptadoCreado = Aes.Create();
            wAESEncriptadoCreado.Mode = CipherMode.CBC;

            byte[] wAESKey = new byte[32];
            Array.Copy(wEncryptKey, 0, wAESKey, 0, 32);
            wAESEncriptadoCreado.Key = wAESKey;
            wAESEncriptadoCreado.IV = xSecretIV;

            MemoryStream wMemoryStream = new MemoryStream();
            ICryptoTransform wAESCryptoTransform = wAESEncriptadoCreado.CreateEncryptor();
            CryptoStream wCryptoStream = new CryptoStream(wMemoryStream, wAESCryptoTransform, CryptoStreamMode.Write);

            byte[] wTextoBytes = Encoding.ASCII.GetBytes(pCadena);
            wCryptoStream.Write(wTextoBytes, 0, wTextoBytes.Length);
            wCryptoStream.FlushFinalBlock();
            byte[] wCifradoBytes = wMemoryStream.ToArray();

            wMemoryStream.Close();
            wCryptoStream.Close();

            string wCifradoTexto = Convert.ToBase64String(wCifradoBytes, 0, wCifradoBytes.Length);
            return wCifradoTexto;
        }

        public static string DecryptStringAES256(string pCadena)
        {
            SHA256 wSHA256 = SHA256.Create();
            byte[] wEncryptKey = wSHA256.ComputeHash(Encoding.ASCII.GetBytes(xEncryptKey));

            Aes wAESEncriptadoCreado = Aes.Create();
            wAESEncriptadoCreado.Mode = CipherMode.CBC;

            byte[] wAESKey = new byte[32];
            Array.Copy(wEncryptKey, 0, wAESKey, 0, 32);
            wAESEncriptadoCreado.Key = wAESKey;
            wAESEncriptadoCreado.IV = xSecretIV;

            MemoryStream wMemoryStream = new MemoryStream();
            ICryptoTransform wAESDesCryptoTransform = wAESEncriptadoCreado.CreateDecryptor();
            CryptoStream wCryptoStream = new CryptoStream(wMemoryStream, wAESDesCryptoTransform, CryptoStreamMode.Write);

            string wDescrifadoTexto = string.Empty;

            try
            {
                byte[] wCifradoBytes = Convert.FromBase64String(pCadena);
                wCryptoStream.Write(wCifradoBytes, 0, wCifradoBytes.Length);
                wCryptoStream.FlushFinalBlock();
                byte[] wTextoBytes = wMemoryStream.ToArray();

                wDescrifadoTexto = Encoding.ASCII.GetString(wTextoBytes, 0, wTextoBytes.Length);
            }
            finally
            {
                wMemoryStream.Close();
                wCryptoStream.Close();
            }

            return wDescrifadoTexto;
        }


        #region ROE

        private static string LlaveEncryptKeyROE = "L@br0eW3b2021";
        public static string EncryptStringAES256ROE(string pCadena)
        {
            SHA256 wSHA256 = SHA256.Create();
            byte[] wEncryptKey = wSHA256.ComputeHash(Encoding.ASCII.GetBytes(LlaveEncryptKeyROE));

            Aes wAESEncriptadoCreado = Aes.Create();
            wAESEncriptadoCreado.Mode = CipherMode.CBC;

            byte[] wAESKey = new byte[32];
            Array.Copy(wEncryptKey, 0, wAESKey, 0, 32);
            wAESEncriptadoCreado.Key = wAESKey;
            wAESEncriptadoCreado.IV = xSecretIV;

            MemoryStream wMemoryStream = new MemoryStream();
            ICryptoTransform wAESCryptoTransform = wAESEncriptadoCreado.CreateEncryptor();
            CryptoStream wCryptoStream = new CryptoStream(wMemoryStream, wAESCryptoTransform, CryptoStreamMode.Write);

            byte[] wTextoBytes = Encoding.ASCII.GetBytes(pCadena);
            wCryptoStream.Write(wTextoBytes, 0, wTextoBytes.Length);
            wCryptoStream.FlushFinalBlock();
            byte[] wCifradoBytes = wMemoryStream.ToArray();

            wMemoryStream.Close();
            wCryptoStream.Close();

            string wCifradoTexto = Convert.ToBase64String(wCifradoBytes, 0, wCifradoBytes.Length);
            return wCifradoTexto;
        }

        #endregion

        //INI 1.0
        #region ApiAgenda

        public static string GenerateHash(string input, string salKey)
        {
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(salKey)))
            {
                var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(hashBytes);
            }
        }
        #endregion
        //FIN 1.0

    }
}