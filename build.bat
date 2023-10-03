::This is the windows version of the build script, this compiles into a folder which will be used as an EB repo for AWS CI/CD
@echo off
pushd Client/
call npm run build
pushd ../Api/
call dotnet publish -c Release -o ../TeamFiveBuild --self-contained true -r linux-x64
popd
