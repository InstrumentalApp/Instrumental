::This is the windows version of the build script, this compiles into a folder which will be used as an EB repo for AWS CI/CD
@echo off
pushd Client
call npm i
call npm run build
popd
xcopy ".\instrument-pictures\*.*" ".\Api\wwwroot\client\assets\instrument-pictures\" /E /H /C /I
pushd Api
call dotnet restore
call dotnet publish -c Release -o ../TeamFiveBuild --self-contained true -r linux-x64
popd