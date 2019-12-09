node(){
    try {
        stage("Checkout SCM"){
            checkout scm
        }
        stage("Restore Dependencies"){
            powershell '''
                nuget restore csharp-hello-world.sln
            '''
        }
        stage("Build and Publish"){
            powershell '''
                msbuild csharp-hello-world.sln /t:Clean,Build /p:Platform="Any CPU" /p:Configuration="Release" /nologo /p:OutputPath="build"
            '''
        }
    } catch (e){
        throw e
    } finally {
        cleanWs()
    }
}