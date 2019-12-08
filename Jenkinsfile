node(){
    stage("Checkout SCM"){
        checkout scm
    }
    stage("Restore Dependencies"){
        powershell '''
            nuget restore csharp-hello-world.sln
        '''
    }
    stage("Build"){

    }
    stage("Publish"){

    }
}