#This is the shell version of the build script, this compiles into a folder which will be used as an EB repo for AWS CI/CD
pushd Client/
npm run build
pushd ../Api/
dotnet publish -c Release -o ../TeamFiveBuild --self-contained true -r linux-x64
popd