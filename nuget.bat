@echo off
cls
".nuget\nuget.exe" "install" "FSharp.Formatting" "-OutputDirectory" "packages" "-ExcludeVersion" -Prerelease
pause