
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
        PUBLISH_DIR = "${WORKSPACE}\\publish"
        REMOTE_HOST = '192.168.42.155'
        REMOTE_DIR = 'E:\\DigitalizacionHC\\Prueba'
        SSH_CREDENTIALS_ID = 'ssh-server-42-155'
        REPO_ROOT = "${WORKSPACE}\\CLINICA"
        
        // SonarQube Configuration
        SONAR_SCANNER_HOME = 'D:\\Sonar\\sonar-scanner'
        SONAR_HOST_URL = 'http://localhost:9000'
        SONAR_LOGIN = credentials('Sonnar')
        BUILD_DISPLAY_NAME = "${env.BUILD_NUMBER}"
    }

    stages {
        stage('Preparación Inicial') {
            steps {
                bat '''
                    @echo off
                    echo Ejecutando script de versión...
                    pushd "C:\\Users\\jdiaz\\Desktop\\"
                    call "incrementar version.bat"
                    popd
                    
                    echo Limpiando workspace y herramientas anteriores...
                    dotnet tool uninstall dotnet-sonarscanner --global || echo "Herramienta no estaba instalada"
                    if exist ".sonarqube" rmdir /s /q ".sonarqube"
                    if exist ".sonar" rmdir /s /q ".sonar"
                    mkdir "${WORKSPACE}\\.sonarqube"
                    mkdir "${WORKSPACE}\\.sonar"
                '''
                cleanWs()
            }
        }

        stage('Obtener Código Fuente') {
            steps {
                script {
                    bat """
                        if not exist "${REPO_ROOT}\\.git" (
                            echo Clonando repositorio...
                            git clone https://github.com/AnthonyDiazCabanillas/CLINICA.git "${REPO_ROOT}"
                        ) else (
                            echo Actualizando repositorio existente...
                            pushd "${REPO_ROOT}"
                            git pull
                            popd
                        )
                    """
                }
            }
        }

        stage('Validar Estructura') {
            steps {
                script {
                    def projects = [
                        "${REPO_ROOT}\\WSAgenda\\WSAgenda.csproj",
                        "${REPO_ROOT}\\Api.Clinica\\Api.Clinica.csproj",
                        "${REPO_ROOT}\\ApiWebClinicaMedico\\ApiPaginaWebCSF.csproj",
                        "${REPO_ROOT}\\WebAppCitaAgenda\\WebAppCitaAgenda.csproj",
                        "${REPO_ROOT}\\Web.Clinica\\Web.Clinica.csproj"
                    ]

                    projects.each { project ->
                        bat """
                            if not exist "${project}" (
                                echo "ERROR: No se encontró el archivo de proyecto: ${project}"
                                exit 1
                            )
                        """
                    }
                }
            }
        }

        stage('Análisis de Calidad') {
            steps {
                script {
                    withSonarQubeEnv('SonarQube') {
                        withCredentials([string(credentialsId: 'Sonnar', variable: 'SONAR_TOKEN')]) {
                            bat """
                                @echo off
                                echo [SONARQUBE] Instalando scanner...
                                dotnet tool install --global dotnet-sonarscanner --version=5.13.0
                                
                                echo [SONARQUBE] Iniciando análisis...
                                dotnet sonarscanner begin ^
                                  /k:"CLINICA" ^
                                  /d:sonar.host.url="${SONAR_HOST_URL}" ^
                                  /d:sonar.token="${SONAR_TOKEN}" ^
                                  /d:sonar.projectVersion=${BUILD_DISPLAY_NAME} ^
                                  /d:sonar.branch.name=main ^
                                  /d:sonar.sourceEncoding=UTF-8 ^
                                  /d:sonar.working.directory="${WORKSPACE}\\.sonar" ^
                                  /d:sonar.cs.analyzer.projectOutPaths="${WORKSPACE}\\.sonarqube\\out" ^
                                  /d:sonar.exclusions="**/bin/**,**/obj/**,**/Ent.Sql/ClinicaE/ComprobantesE/**,**/WSAgenda/Worker.cs" ^
                                  /d:sonar.coverage.exclusions="**Test**.cs" ^
                                  /d:sonar.verbose=true ^
                                  /d:sonar.scm.disabled=true ^
                                  /d:sonar.cs.ignoreIssues=false ^
                                  /d:sonar.cs.warnignsAsErrors=false
                                
                                echo [SONARQUBE] Ejecutando build para análisis...
                                dotnet build "${REPO_ROOT}" --configuration Release -p:TreatWarningsAsErrors=false -p:NoWarn=CS0414
                                
                                echo [SONARQUBE] Finalizando análisis...
                                dotnet sonarscanner end /d:sonar.token="${SONAR_TOKEN}"
                            """
                        }
                    }
                }
            }
        }

        stage('Compilación y Pruebas') {
            steps {
                dir("${REPO_ROOT}") {
                    bat '''
                        echo Restaurando dependencias...
                        dotnet restore
                        
                        echo Compilando proyectos...
                        dotnet build --configuration Release -p:TreatWarningsAsErrors=false -p:NoWarn=CS0414
                        
                        echo Ejecutando pruebas...
                        dotnet test --no-build --configuration Release
                    '''
                }
            }
        }

        stage('Publicación') {
            steps {
                dir("${REPO_ROOT}") {
                    bat """
                        echo Publicando proyectos...
                        dotnet publish WSAgenda/WSAgenda.csproj --configuration Release --output ${PUBLISH_DIR}/WSAgenda --no-build
                        dotnet publish Api.Clinica/Api.Clinica.csproj --configuration Release --output ${PUBLISH_DIR}/Api.Clinica --no-build
                        dotnet publish ApiWebClinicaMedico/ApiPaginaWebCSF.csproj --configuration Release --output ${PUBLISH_DIR}/ApiWebClinicaMedico --no-build
                        dotnet publish WebAppCitaAgenda/WebAppCitaAgenda.csproj --configuration Release --output ${PUBLISH_DIR}/WebAppCitaAgenda --no-build
                        dotnet publish Web.Clinica/Web.Clinica.csproj --configuration Release --output ${PUBLISH_DIR}/WebClinica --no-build
                        
                        echo Limpiando archivos de configuración...
                        if exist "${PUBLISH_DIR}\\*.config" del /s /q "${PUBLISH_DIR}\\*.config"
                    """
                }
            }
        }

        stage('Despliegue') {
            steps {
                script {
                    withCredentials([sshUserPrivateKey(
                        credentialsId: "${SSH_CREDENTIALS_ID}",
                        keyFileVariable: 'SSH_KEY',
                        usernameVariable: 'SSH_USER'
                    )]) {
                        bat """
                            echo Desplegando en servidor remoto...
                            robocopy "${PUBLISH_DIR}" "\\\\${REMOTE_HOST}\\${REMOTE_DIR.replace(':', '$')}" /E /ZB /R:1 /W:1 /MT:16
                        """
                    }
                }
            }
        }

        stage('Verificación de Calidad') {
            steps {
                timeout(time: 15, unit: 'MINUTES') {
                    waitForQualityGate abortPipeline: true
                }
            }
        }
    }

    post {
        always {
            bat '''
                echo Limpieza final...
                dotnet tool uninstall dotnet-sonarscanner --global || echo "No se pudo desinstalar"
            '''
            cleanWs()
        }
        success {
            echo 'Pipeline ejecutado exitosamente! Análisis de calidad completado.'
        }
        failure {
            echo 'Pipeline falló. Consultar logs para detalles.'
            // Opcional: Agregar notificación por email/teams/etc.
        }
    }
}