mkdir Builds
mkdir Builds\Windows
mkdir Builds\Linux
mkdir Builds\OSX

"C:\Program Files (x86)\Unity\Editor\Unity.exe" -batchmode -quit ^
	-buildWindowsPlayer "Builds\Windows\JumpFrog.exe" ^
	-buildLinux32Player "Builds\Linux\JumpFrog" ^
	-buildOSXPlayer "Builds\OSX\JumpFrog.app"