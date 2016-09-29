<#
.SYNOPSIS
    Run .NET Console Sample Image
.DESCRIPTION
    Runs .NET Console Sample Image
#>


Set-StrictMode -Version Latest
$ErrorActionPreference="Stop"
$ProgressPreference="SilentlyContinue"

function Invoke-Docker-Run ([string]$ImageName, [string]$QuestionArgs) {
	echo "docker run --rm $ImageName $QuestionArgs"
	Invoke-Expression "docker run --rm $ImageName $QuestionArgs"
}

function Invoke-Docker-Build ([string]$ImageName, [string]$ImagePath, [string]$DockerBuildArgs = "") {
    echo "docker build -t $ImageName $ImagePath $DockerBuildArgs"
    Invoke-Expression "docker build -t $ImageName $ImagePath $DockerBuildArgs"
}

function Invoke-MSBuild ([string]$MSBuildPath, [string]$MSBuildParameters) {
    Invoke-Expression "$MSBuildPath $MSBuildParameters"
}

Invoke-MSBuild -MSBuildPath "MSBuild.exe" -MSBuildParameters ".\Magic8Ball.csproj /p:OutputDir=.\publish /p:Configuration=Release"
Invoke-Docker-Build -ImageName "magic8ball" -ImagePath "."
Invoke-Docker-Run -ImageName "magic8ball" -QuestionArgs "Is this a square container?"