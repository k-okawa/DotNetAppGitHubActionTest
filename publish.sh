rm -rf build
mkdir build

dotnet publish -c release -r linux-x64 -o build/linux-x64/ --self-contained