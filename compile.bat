@echo off
clear
gcc -O2 -s -DNDEBUG C/main.c -o C/C_test.exe
dotnet restore C#
dotnet run --project ".\C#\CS Test.csproj" --configuration release
clear

