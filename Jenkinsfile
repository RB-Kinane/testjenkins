node {
  stage('SCM') {
    checkout scm
  }
  stage('SonarQube Analysis') {
    def scannerHome = tool 'SonarDotnet_v1'
    withSonarQubeEnv() {
      bat "dotnet restore Jenkins-test/Jenkins-test.sln"
      bat "dotnet ${scannerHome}\\SonarScanner.MSBuild.dll begin /k:\"Jenkins_v1\""
      bat "dotnet build Jenkins-test/Jenkins-test/Jenkins-test.csproj"
      bat "dotnet ${scannerHome}\\SonarScanner.MSBuild.dll end"
    }
  }
}
