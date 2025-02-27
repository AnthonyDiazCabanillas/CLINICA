/*pipeline {
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
                    bat 'scp -r ./publish usuario@servidor:/ruta/de/destino'
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
}*/

pipeline {
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
                git branch: 'main', url: 'https://github.com/AnthonyDiazCabanillas/CLINICA.git' // Clona el repositorio
                echo 'Repository cloned.'
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
                echo 'All projects published.'
            }
        }

        // Etapa 7: Desplegar (opcional)
        stage('Deploy') {
            steps {
                script {
                    echo 'Deploying projects...'
                    // Ejemplo: Copiar archivos a un servidor remoto usando SCP
                    bat """
                        if exist "${PUBLISH_DIR}" (
                            scp -r ${PUBLISH_DIR} jdiaz@192.168.42.155:DigitalizacionHC/Prueba
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