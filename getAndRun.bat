rmdir /q /s MarsRover

git clone https://github.com/lukespirestba/MarsRover.git

cd MarsRover

dotnet restore
dotnet build --no-restore MarsRoverApplication.sln

MarsRoverApplication\bin\Debug\net6.0\MarsRoverApplication.exe

pause