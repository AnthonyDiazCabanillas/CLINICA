
//**************************************************************************************************************************** //
//***************************************************** PIPELINE CON SONARQ  ************************************************** //
//**************************************************************************************************************************** //

/*pipeline {
    agent any // Ejecuta en cualquier agente disponible

    environment {
        // Define variables de entorno
        DOTNET_VERSION = '6.0' // Versión de .NET
        PUBLISH_DIR = "${WORKSPACE}/publish" // Carpeta de publicación
        SONARQUBE_SCANNER_HOME = tool name: 'SonarScanner', type: 'hudson.plugins.sonar.SonarRunnerInstallation' // Ruta del SonarScanner
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

        // Etapa 3: Configurar y ejecutar SonarQube
        stage('SonarQube Analysis') {
            steps {
                script {
                    // Configuración del análisis de SonarQube
                    withSonarQubeEnv('SonarQube Server') { // Nombre de la configuración del servidor de SonarQube en Jenkins
                      bat """
                                ${SONARQUBE_SCANNER_HOME}/bin/sonar-scanner \\
                                -Dsonar.projectKey=CLINICA \\
                                -Dsonar.projectName=CLINICA \\
                                -Dsonar.projectVersion=1.0 \\
                                -Dsonar.sources=. \\
                                -Dsonar.host.url=http://localhost:9000 \\
                                -Dsonar.login=squ_941fbdc8173333bd713354c95bb5398d2bd00e9b \\
                                -Dsonar.dotnet.excludeProjectReferences=true
                        """
                    }
                }
                echo 'SonarQube analysis completed.'
            }
        }

        // Etapa 4: Restaurar dependencias de .NET
        stage('Restore Dependencies') {
            steps {
                bat 'dotnet restore' // Restaura los paquetes NuGet para todos los proyectos
                echo 'Dependencies restored.'
            }
        }

        // Etapa 5: Compilar los proyectos
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

        // Etapa 6: Ejecutar pruebas (opcional)
       /* stage('Run Tests') {
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

        // Etapa 7: Publicar los proyectos
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

        // Etapa 8: Desplegar (opcional)
        stage('Deploy') {
            steps {
                script {
                    echo 'Deploying projects...'
                    def destinationDir = "D:\\DigitalizacionHC\\Prueba"
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
}*/

//**************************************************************************************************************************** //
//***************************************************** PIPELINE PARA COPIADO EN UNA CARPETA  ************************************************** //
//**************************************************************************************************************************** //
/*
pipeline {
    agent any

    environment {
        DOTNET_VERSION = '6.0'
        PUBLISH_DIR = "${WORKSPACE}/publish"
        REMOTE_HOST = '192.168.42.155'
        REMOTE_DIR = 'E:\\DigitalizacionHC\\Prueba'
        SSH_CREDENTIALS_ID = 'ssh-server-42-155'
        TARGET_SHARE = '\\\\192.168.42.252\\Temporal\\GLluncor\\___Desarrollo\\Jenkins'
        REPO_ROOT = "${WORKSPACE}/CLINICA"
    }

    stages {
        stage('Ejecutar Batch') {
            steps {
                bat '''
                    pushd "C:\\Users\\jdiaz\\Desktop\\"
                    call "incrementar version.bat"
                    popd
                '''
            }
        }

        stage('Clean Workspace') {
            steps {
                cleanWs()
                echo 'Workspace cleaned.'
            }
        }

        stage('Checkout') {
            steps {
                script {
                    bat """
                    if not exist "${REPO_ROOT}\\.git" (
                        git clone https://github.com/AnthonyDiazCabanillas/CLINICA.git "${REPO_ROOT}"
                    )
                    """
                }
            }
        }

        stage('Validate Project Structure') {
            steps {
                script {
                    def projects = [
                        "${REPO_ROOT}/WSAgenda/WSAgenda.csproj",
                        "${REPO_ROOT}/Api.Clinica/Api.Clinica.csproj",
                        "${REPO_ROOT}/ApiWebClinicaMedico/ApiPaginaWebCSF.csproj",
                        "${REPO_ROOT}/WebAppCitaAgenda/WebAppCitaAgenda.csproj",
                        "${REPO_ROOT}/Web.Clinica/Web.Clinica.csproj"
                    ]

                    projects.each { project ->
                        bat """
                        if not exist "${project}" (
                            echo "ERROR: Project file not found: ${project}"
                            exit 1
                        )
                        """
                    }
                }
            }
        }

        stage('Restore Dependencies') {
            steps {
                dir("${REPO_ROOT}") {
                    bat 'dotnet restore'
                }
                echo 'Dependencies restored.'
            }
        }

        stage('Build') {
            steps {
                dir("${REPO_ROOT}") {
                    bat 'dotnet build WSAgenda/WSAgenda.csproj --configuration Release'
                    bat 'dotnet build Api.Clinica/Api.Clinica.csproj --configuration Release'
                    bat 'dotnet build ApiWebClinicaMedico/ApiPaginaWebCSF.csproj --configuration Release'
                    bat 'dotnet build WebAppCitaAgenda/WebAppCitaAgenda.csproj --configuration Release'
                    bat 'dotnet build Web.Clinica/Web.Clinica.csproj --configuration Release'
                }
                echo 'All projects built successfully.'
            }
        }

        stage('Run Tests') {
            steps {
                dir("${REPO_ROOT}") {
                    bat 'dotnet test WSAgenda/WSAgenda.csproj'
                    bat 'dotnet test Api.Clinica/Api.Clinica.csproj'
                    bat 'dotnet test ApiWebClinicaMedico/ApiPaginaWebCSF.csproj'
                    bat 'dotnet test WebAppCitaAgenda/WebAppCitaAgenda.csproj'
                    bat 'dotnet test Web.Clinica/Web.Clinica.csproj'
                }
                echo 'Tests executed.'
            }
        }

        stage('Publish') {
            steps {
                dir("${REPO_ROOT}") {
                    bat "dotnet publish WSAgenda/WSAgenda.csproj --configuration Release --output ${PUBLISH_DIR}/WSAgenda"
                    bat "dotnet publish Api.Clinica/Api.Clinica.csproj --configuration Release --output ${PUBLISH_DIR}/Api.Clinica"
                    bat "dotnet publish ApiWebClinicaMedico/ApiPaginaWebCSF.csproj --configuration Release --output ${PUBLISH_DIR}/ApiWebClinicaMedico"
                    bat "dotnet publish WebAppCitaAgenda/WebAppCitaAgenda.csproj --configuration Release --output ${PUBLISH_DIR}/WebAppCitaAgenda"
                    bat "dotnet publish Web.Clinica/Web.Clinica.csproj --configuration Release --output ${PUBLISH_DIR}/WebClinica"
                }
                bat "del /s /q \"${PUBLISH_DIR}\\*.config\""
                echo 'All projects published.'
            }
        }
        
        stage('Deploy to Network Share') {
            steps {
                script {
                    withCredentials([usernamePassword(
                        credentialsId: 'REMOTO',
                        usernameVariable: 'NET_USER',
                        passwordVariable: 'NET_PASS'
                    )]) {
                        bat """
                        net use Z: "\\\\192.168.42.252\\Temporal" /user:%NET_USER% %NET_PASS% /persistent:no
                        if not exist "Z:\\GLluncor\\___Desarrollo\\Jenkins" (
                            mkdir "Z:\\GLluncor\\___Desarrollo\\Jenkins"
                        )
                        robocopy "${REPO_ROOT}" "Z:\\GLluncor\\___Desarrollo\\Jenkins\\CLINICA" /MIR /NJH /NJS /NP
                        net use Z: /delete
                        """
                    }
                }
            }
        }
        stage('Deploy to Remote Server') {
            steps {
                script {
                    withCredentials([sshUserPrivateKey(
                        credentialsId: "${SSH_CREDENTIALS_ID}",
                        keyFileVariable: 'SSH_KEY',
                        usernameVariable: 'SSH_USER'
                    )]) {
                        bat """
                        scp -i "${SSH_KEY}" -r "${PUBLISH_DIR}" ${SSH_USER}@${REMOTE_HOST}:"${REMOTE_DIR}"
                        """
                    }
                    echo 'Projects deployed to remote server.'
                }
            }
        }
    }

    post {
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
    agent any

    environment {
        DOTNET_VERSION = '6.0'
        PUBLISH_DIR = "${WORKSPACE}/publish"
        REMOTE_HOST = '192.168.42.155'
        REMOTE_DIR = '\\Jenkins\\Prueba'
        SSH_CREDENTIALS_ID = 'ssh-server-42-155'
        REPO_ROOT = "${WORKSPACE}/CLINICA"
        
        // SonarQube Configuration
        SONAR_SCANNER_HOME = 'D:\\Sonar\\sonar-scanner' // Path to SonarScanner on Jenkins agent                       
        SONAR_HOST_URL = 'http://localhost:9000/' // SonarQube server URL
        SONAR_LOGIN = credentials('Sonnar') // SonarQube token stored in Jenkins
    }

    stages {
        stage('Ejecutar Batch') {
            steps {
                bat '''
                    pushd "C:\\Users\\jdiaz\\Desktop\\"
                    call "incrementar version.bat"
                    popd
                '''
            }
        }

        stage('Clean Workspace') {
            steps {
                cleanWs()
                echo 'Workspace cleaned.'
            }
        }

        stage('Checkout') {
            steps {
                script {
                    bat """
                    if not exist "${REPO_ROOT}\\.git" (
                        git clone https://github.com/AnthonyDiazCabanillas/CLINICA.git "${REPO_ROOT}"
                    )
                    """
                }
            }
        }

        stage('Validate Project Structure') {
            steps {
                script {
                    def projects = [
                        "${REPO_ROOT}/WSAgenda/WSAgenda.csproj",
                        "${REPO_ROOT}/Api.Clinica/Api.Clinica.csproj",
                        "${REPO_ROOT}/ApiWebClinicaMedico/ApiPaginaWebCSF.csproj",
                        "${REPO_ROOT}/WebAppCitaAgenda/WebAppCitaAgenda.csproj",
                        "${REPO_ROOT}/Web.Clinica/Web.Clinica.csproj"
                    ]

                    projects.each { project ->
                        bat """
                        if not exist "${project}" (
                            echo "ERROR: Project file not found: ${project}"
                            exit 1
                        )
                        """
                    }
                }
            }
        }

       /* stage('SonarQube Analysis') {
            steps {
                withSonarQubeEnv('SonarQube') {
                    withCredentials([string(credentialsId: 'Sonnar', variable: 'SONAR_TOKEN')]) {*/
                     //   bat """
                       //     "%SONAR_SCANNER_HOME%\\bin\\sonar-scanner.bat" ^
                         //   -Dsonar.projectKey=Prueba2^
                          //  -Dsonar.projectName=Prueba2 ^
                            //-Dsonar.projectVersion=1.0 ^
                     //       -Dsonar.sources=. ^
                     //       -Dsonar.host.url=http://localhost:9000 ^
                    //        -Dsonar.token=%SONAR_TOKEN% ^
                     //       -Dsonar.dotnet.excludeTestProjects=true ^
                     //       -Dsonar.coverage.exclusions=**/*Test*/**
                     //   """
                  /*  }
                }
            
        }*/
        
        stage('Restore Dependencies') {
            steps {
                dir("${REPO_ROOT}") {
                    bat 'dotnet restore'
                }
                echo 'Dependencies restored.'
            }
        }

        stage('Build') {
            steps {
                dir("${REPO_ROOT}") {
                    bat 'dotnet build WSAgenda/WSAgenda.csproj --configuration Release'
                    bat 'dotnet build Api.Clinica/Api.Clinica.csproj --configuration Release'
                    bat 'dotnet build ApiWebClinicaMedico/ApiPaginaWebCSF.csproj --configuration Release'
                    bat 'dotnet build WebAppCitaAgenda/WebAppCitaAgenda.csproj --configuration Release'
                    bat 'dotnet build Web.Clinica/Web.Clinica.csproj --configuration Release'
                }
                echo 'All projects built successfully.'
            }
        }

        stage('Run Tests') {
            steps {
                dir("${REPO_ROOT}") {
                    bat 'dotnet test WSAgenda/WSAgenda.csproj'
                    bat 'dotnet test Api.Clinica/Api.Clinica.csproj'
                    bat 'dotnet test ApiWebClinicaMedico/ApiPaginaWebCSF.csproj'
                    bat 'dotnet test WebAppCitaAgenda/WebAppCitaAgenda.csproj'
                    bat 'dotnet test Web.Clinica/Web.Clinica.csproj'
                }
                echo 'Tests executed.'
            }
        }

        stage('Publish') {
            steps {
                dir("${REPO_ROOT}") {
                    bat "dotnet publish WSAgenda/WSAgenda.csproj --configuration Release --output ${PUBLISH_DIR}/WSAgenda"
                    bat "dotnet publish Api.Clinica/Api.Clinica.csproj --configuration Release --output ${PUBLISH_DIR}/Api.Clinica"
                    bat "dotnet publish ApiWebClinicaMedico/ApiPaginaWebCSF.csproj --configuration Release --output ${PUBLISH_DIR}/ApiWebClinicaMedico"
                    bat "dotnet publish WebAppCitaAgenda/WebAppCitaAgenda.csproj --configuration Release --output ${PUBLISH_DIR}/WebAppCitaAgenda"
                    bat "dotnet publish Web.Clinica/Web.Clinica.csproj --configuration Release --output ${PUBLISH_DIR}/WebClinica"
                }
                bat "del /s /q \"${PUBLISH_DIR}\\*.config\""
                echo 'All projects published.'
            }
        }
    
      stage('Deploy to Remote Server') {
    steps {
        script {
            withCredentials([usernamePassword(
                credentialsId: 'windows-server-creds',
                usernameVariable: 'REMOTE_USER',
                passwordVariable: 'REMOTE_PASS'
            )]) {
                bat """
                    net use Z: "\\\\${REMOTE_HOST}\\D\\$" /user:%REMOTE_USER% %REMOTE_PASS% /persistent:no
                    if %errorlevel% neq 0 (
                        echo Error al mapear unidad de red
                        exit 1
                    )
                    
                    robocopy "${PUBLISH_DIR}" "Z:\\Jenkins\\Prueba" /MIR /Z /W:5 /NP /NFL /NDL
                    set robocopy_result=%errorlevel%
                    
                    net use Z: /delete
                    
                    if %robocopy_result% gtr 1 (
                        echo Error durante robocopy. Código: %robocopy_result%
                        exit 1
                    ) else (
                        echo Copia completada exitosamente
                    )
                """
            }
        }
    }
}

        /*stage('Quality Gate Check') {
            steps {
                timeout(time: 15, unit: 'MINUTES') {
                    waitForQualityGate abortPipeline: true
                }
            }
        }*/
    }
}