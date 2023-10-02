set exeFile=Packages\nunit.consolerunner\3.16.3\tools\nunit3-console.exe
set dllFile=UnitTestsLab1\\bin\\Debug\\net6.0\\UnitTestsLab1.dll

if exist "%exeFile%" (
    if exist "%dllFile%" (
        "%exeFile%" "%dllFile%"
    ) else (
        echo "%dllFile%" not found.
    )
) else (
    echo "%exeFile%" not found.
)

pause