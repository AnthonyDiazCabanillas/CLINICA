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

       stage('SonarQube Analysis') {
            steps {
                withSonarQubeEnv('SonarQube') {
                    withCredentials([string(credentialsId: 'Sonnar', variable: 'SONAR_TOKEN')]) {
                      bat """
                            "%SONAR_SCANNER_HOME%\\bin\\sonar-scanner.bat" ^
                            -Dsonar.projectKey=Integracion^
                            -Dsonar.projectName=Integracion^
                            -Dsonar.projectVersion=1.0 ^
                            -Dsonar.sources=. ^
                            -Dsonar.host.url=http://localhost:9000 ^
                            -Dsonar.token=%SONAR_TOKEN% ^
                            -Dsonar.dotnet.excludeTestProjects=true ^
                            -Dsonar.coverage.exclusions=**/*Test*/**
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

    stage('Deploy to Remote Server') {
        steps {
            script {
            withCredentials([usernamePassword(
                credentialsId: 'windows-server-creds',
                usernameVariable: 'REMOTE_USER',
                passwordVariable: 'REMOTE_PASS'
            )]) {
                bat """
                    @echo off
                    echo Intentando mapear unidad de red...
                    net use Z: "\\\\${REMOTE_HOST}\\D\$" /user:%REMOTE_USER% %REMOTE_PASS% /persistent:no
                    if %errorlevel% neq 0 (
                        echo ERROR: Fallo al mapear unidad de red
                        exit /b 1
                    )
                    
                    echo Copiando archivos...
                    robocopy "${PUBLISH_DIR}" "Z:\\Jenkins\\Prueba" /MIR /Z /W:5 /NP /NFL /NDL
                    set robocopy_result=%errorlevel%
                    
                    echo Desmapeando unidad...
                    net use Z: /delete /y
                    
                    if %robocopy_result% gtr 1 (
                        echo ERROR en robocopy. CÃ³digo: %robocopy_result%
                        exit /b 1
                    ) else (
                        echo Copia completada exitosamente
                    )
                """
            }
        }
    }
}
        stage('Quality Gate Check') {
            steps {
                timeout(time: 15, unit: 'MINUTES') {
                    waitForQualityGate abortPipeline: true
                }
            }
        }
    }
}