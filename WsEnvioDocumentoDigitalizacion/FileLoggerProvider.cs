//***************************************************************************************
//    Copyright Clinica San Felipe S.A.C 2024. Todos los derechos reservados.
//    MODIFICACIONES:
//    Version         Fecha       Autor       Requerimiento
//    1.0         05/08/2024     HVIDAL       REQ 2024-011506 
//****************************************************************************************
using Microsoft.Extensions.Logging;
namespace WsEnvioDocumentoDigitalizacion
{
    public class FileLoggerProvider : ILoggerProvider
	{
		
		private readonly string path;

		public FileLoggerProvider(string path)
		{
			this.path = path;
		}

		public ILogger CreateLogger(string categoryName)
		{
			return new FileLogger(path);
		}

		public void Dispose()
		{			
		}
    }
}