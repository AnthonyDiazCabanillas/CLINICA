/*pipeline {
    agent any // Ejecuta en cualquier agente disponible

    environment {
        // Define variables de entorno
        DOTNET_VERSION = '6.0' // Versión de .NET
        PUBLISH_DIR = "${WORKSPACE}/publish" // Carpeta de publicación
    }

    stages {
        // Etapa 1: Limpiar el workspace
        stage('Clean Workspace') {
            steps {
                cleanWs() // Limpia el workspace
                echo 'Workspace cleaned.'
            }
        }

        // Etapa 2: Clonar el repositorio
        stage('Checkout') {
            steps {
                git(
                    url: 'https://github.com/AnthonyDiazCabanillas/CLINICA.git',
                    branch: 'main'
                )
            }
        }
    

        // Etapa 3: Restaurar dependencias de .NET
        stage('Restore Dependencies') {
            steps {
                bat 'dotnet restore' // Restaura los paquetes NuGet para todos los proyectos
                echo 'Dependencies restored.'
            }
        }

        // Etapa 4: Compilar los proyectos
        stage('Build') {
            steps {
                // Compila cada proyecto individualmente
                bat 'dotnet build ./WSAgenda/WSAgenda.csproj --configuration Release'
                bat 'dotnet build ./Api.Clinica/Api.Clinica.csproj --configuration Release'
                bat 'dotnet build ./ApiWebClinicaMedico/ApiPaginaWebCSF.csproj --configuration Release'
                bat 'dotnet build ./WebAppCitaAgenda/WebAppCitaAgenda.csproj --configuration Release'
                bat 'dotnet build ./Web.Clinica/Web.Clinica.csproj --configuration Release'
                echo 'All projects built successfully.'
            }
        }

        // Etapa 5: Ejecutar pruebas (opcional)
        stage('Run Tests') {
            steps {
                // Ejecuta pruebas unitarias para cada proyecto (si existen)
                bat 'dotnet test ./WSAgenda/WSAgenda.csproj'
                bat 'dotnet test ./Api.Clinica/Api.Clinica.csproj'
                bat 'dotnet test ./ApiWebClinicaMedico/ApiPaginaWebCSF.csproj'
                bat 'dotnet test ./WebAppCitaAgenda/WebAppCitaAgenda.csproj'
                bat 'dotnet test ./Web.Clinica/Web.Clinica.csproj'
                echo 'Tests executed.'
            }
        }

        // Etapa 6: Publicar los proyectos
        stage('Publish') {
            steps {
                // Publica cada proyecto en la carpeta de publicación
                bat "dotnet publish ./WSAgenda/WSAgenda.csproj --configuration Release --output ${PUBLISH_DIR}/WSAgenda"
                bat "dotnet publish ./Api.Clinica/Api.Clinica.csproj --configuration Release --output ${PUBLISH_DIR}/Api.Clinica"
                bat "dotnet publish ./ApiWebClinicaMedico/ApiPaginaWebCSF.csproj --configuration Release --output ${PUBLISH_DIR}/ApiWebClinicaMedico"
                bat "dotnet publish ./WebAppCitaAgenda/WebAppCitaAgenda.csproj --configuration Release --output ${PUBLISH_DIR}/WebAppCitaAgenda"
                bat "dotnet publish ./Web.Clinica/Web.Clinica.csproj --configuration Release --output ${PUBLISH_DIR}/WebClinica"
                
                echo 'All projects published.'
            }
        }

        // Etapa 7: Desplegar (opcional)
        stage('Deploy') {
            steps {
                script {
                    echo 'Deploying projects...'
                    def destinationDir = '\\\\192.168.42.155\\E$\\DigitalizacionHC\\Prueba'
                    bat """
                        if not exist "${destinationDir}" (
                        mkdir "${destinationDir}"
                        )
                    """

                    // Ejemplo: Copiar archivos a un servidor remoto usando SCP
                    bat """
                        if exist "${PUBLISH_DIR}" (
                                    robocopy "${PUBLISH_DIR}" "${destinationDir}" /E                        
                        )
                    """
                    echo 'Projects deployed.'
                }
            }
        }
    }

    post {
        // Acciones posteriores a la ejecución del pipeline
        success {
            echo 'Pipeline completed successfully!'
        }
        failure {
            echo 'Pipeline failed. Check the logs for details.'
        }
    }
}
*/
pipeline {
    agent any // Ejecuta en cualquier agente disponible

    environment {
        // Define variables de entorno
        DOTNET_VERSION = '6.0' // Versión de .NET
        PUBLISH_DIR = "${WORKSPACE}/publish" // Carpeta de publicación
        REMOTE_USER = 'SANFELIPE\\judiaz' // Usuario del servidor remoto
        REMOTE_HOST = '192.168.42.155' // Dirección del servidor remoto
        REMOTE_DIR = "\\\\E\\\$\\DigitalizacionHC\\Prueba" // Ruta de destino en el servidor remoto// Ruta de destino en el servidor remoto
        SSH_CREDENTIALS_ID = 'ssh-server-42-155' // ID de las credenciales SSH configuradas en Jenkins
    }

    stages {
        // Etapa 1: Limpiar el workspace
        stage('Clean Workspace') {
            steps {
                cleanWs() // Limpia el workspace
                echo 'Workspace cleaned.'
            }
        }

        // Etapa 2: Clonar el repositorio
        stage('Checkout') {
            steps {
                git(
                    url: 'https://github.com/AnthonyDiazCabanillas/CLINICA.git',
                    branch: 'main'
                )
            }
        }

        // Etapa 3: Restaurar dependencias de .NET
        stage('Restore Dependencies') {
            steps {
                bat 'dotnet restore' // Restaura los paquetes NuGet para todos los proyectos
                echo 'Dependencies restored.'
            }
        }

        // Etapa 4: Compilar los proyectos
        stage('Build') {
            steps {
                // Compila cada proyecto individualmente
                bat 'dotnet build ./WSAgenda/WSAgenda.csproj --configuration Release'
                bat 'dotnet build ./Api.Clinica/Api.Clinica.csproj --configuration Release'
                bat 'dotnet build ./ApiWebClinicaMedico/ApiPaginaWebCSF.csproj --configuration Release'
                bat 'dotnet build ./WebAppCitaAgenda/WebAppCitaAgenda.csproj --configuration Release'
                bat 'dotnet build ./Web.Clinica/Web.Clinica.csproj --configuration Release'
                echo 'All projects built successfully.'
            }
        }

        // Etapa 5: Ejecutar pruebas (opcional)
        stage('Run Tests') {
            steps {
                // Ejecuta pruebas unitarias para cada proyecto (si existen)
                bat 'dotnet test ./WSAgenda/WSAgenda.csproj'
                bat 'dotnet test ./Api.Clinica/Api.Clinica.csproj'
                bat 'dotnet test ./ApiWebClinicaMedico/ApiPaginaWebCSF.csproj'
                bat 'dotnet test ./WebAppCitaAgenda/WebAppCitaAgenda.csproj'
                bat 'dotnet test ./Web.Clinica/Web.Clinica.csproj'
                echo 'Tests executed.'
            }
        }

        // Etapa 6: Publicar los proyectos
        stage('Publish') {
            steps {
                // Publica cada proyecto en la carpeta de publicación
                bat "dotnet publish ./WSAgenda/WSAgenda.csproj --configuration Release --output ${PUBLISH_DIR}/WSAgenda"
                bat "dotnet publish ./Api.Clinica/Api.Clinica.csproj --configuration Release --output ${PUBLISH_DIR}/Api.Clinica"
                bat "dotnet publish ./ApiWebClinicaMedico/ApiPaginaWebCSF.csproj --configuration Release --output ${PUBLISH_DIR}/ApiWebClinicaMedico"
                bat "dotnet publish ./WebAppCitaAgenda/WebAppCitaAgenda.csproj --configuration Release --output ${PUBLISH_DIR}/WebAppCitaAgenda"
                bat "dotnet publish ./Web.Clinica/Web.Clinica.csproj --configuration Release --output ${PUBLISH_DIR}/WebClinica"
                
                echo 'All projects published.'
            }
        }

        // Etapa 7: Desplegar en servidor remoto
        stage('Deploy to Remote Server') {
            steps {
                script {
                    echo 'Deploying projects to remote server...'
                    
                    // Usar SCP para copiar los archivos al servidor remoto
                    withCredentials([sshUserPrivateKey(
                        credentialsId: "${SSH_CREDENTIALS_ID}",
                        keyFileVariable: 'SSH_KEY',
                        usernameVariable: 'SSH_USER'
                    )]) {
                        bat """
                            scp -i "${SSH_KEY}" -r "${PUBLISH_DIR}" ${SSH_USER}@${REMOTE_HOST}:${REMOTE_DIR}
                        """
                    }
                    
                    echo 'Projects deployed to remote server.'
                }
            }
        }
    }

    post {
        // Acciones posteriores a la ejecución del pipeline
        success {
            echo 'Pipeline completed successfully!'
        }
        failure {
            echo 'Pipeline failed. Check the logs for details.'
        }
    }
}