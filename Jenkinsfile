pipeline {
    agent any // Ejecuta el pipeline en cualquier agente disponible

    environment {
        // Variables de entorno (opcional)
        DOTNET_VERSION = "6.0" // Versión de .NET
        BUILD_CONFIGURATION = "Release" // Configuración de compilación (Release o Debug)
        SOLUTION_FILE = 'SanFelipe.sln' // Nombre del archivo de solución
    }

    stages {
        stage('Checkout') {
            steps {
                // Clona el repositorio
                git branch: 'main', url: 'https://github.com/AnthonyDiazCabanillas/CLINICA.git'
            }
        }

        stage('Restore Dependencies') {
            steps {
                // Restaura las dependencias del proyecto
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                // Compila el proyecto
                bat "dotnet build ${SOLUTION_FILE} --configuration ${BUILD_CONFIGURATION}"
            }
        }

        stage('Run Tests') {
            steps {
                // Ejecuta las pruebas unitarias (si hay un proyecto de pruebas)
                bat 'dotnet test'
            }
        }

        stage('Publish') {
            steps {
                // Publica el proyecto para despliegue
                bat "dotnet publish ${SOLUTION_FILE} --configuration ${BUILD_CONFIGURATION} --output ./publish"
            }
        }

        stage('Deploy') {
            steps {
                // Despliega el proyecto (ejemplo para copiar archivos a un servidor)
                script {
                    echo 'Desplegando el proyecto...'
                    // Aquí puedes agregar comandos para copiar los archivos publicados a un servidor
                    // Por ejemplo, usando scp para Linux o Copy-Item para Windows
                    //bat 'scp -r ./publish jdiaz@192.168.42.155:E:\ruta''
                    bat 'xcopy /E /I C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\CLINICA\\publish D:\\ruta'
                }
            }
        }
    }

    post {
        success {
            // Acciones si el pipeline tiene éxito
            echo 'Pipeline completado con éxito!'
        }
        failure {
            // Acciones si el pipeline falla
            echo 'Pipeline falló :('
        }
    }
}