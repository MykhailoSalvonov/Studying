set exeFile=Packages\nunit.consolerunner\3.16.3\tools\nunit3-console.exe
set dllFile=UiTests\bin\Debug\net6.0-windows\UiTests.dll

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