@echo off
 
:: Start NishaChatBot.exe using a relative path
start /d "%~dp0UnityBuild" NishaChatBot.exe
 
:: Activate the virtual environment and start the server with relative paths
cmd /k "cd /d %~dp0Nisha1.0\Scripts & activate & cd /d %~dp0 & uvicorn ServerTest:app --reload"
 
echo All Good!
pause