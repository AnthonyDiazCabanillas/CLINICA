pipeline {
    agent any // Ejecuta el pipeline en cualquier agente disponible

    environment {
        // Variables de entorno (opcional)
        DOTNET_VERSION = "6.0" // Versión de .NET
        PROJECT_NAME = "MiProyecto"
        BUILD_CONFIGURATION = "Release"
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
                bat "dotnet build --configuration ${BUILD_CONFIGURATION}"
            }
        }

        stage('Run Tests') {
            steps {
                // Ejecuta las pruebas unitarias
                bat 'dotnet test'
            }
        }

        stage('Publish') {
            steps {
                // Publica el proyecto para despliegue
                bat "dotnet publish --configuration ${BUILD_CONFIGURATION} --output ./publish"
            }
        }

        stage('Deploy') {
            steps {
                // Despliega el proyecto (ejemplo para copiar archivos a un servidor)
                bat 'scp -r ./publish usuario@servidor:/ruta/de/destino'
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