@echo off
set DB_NAME=QLKTX
set BK_FILE=%cd%\%DB_NAME%.bak
set DB_HOSTNAME=(local)
echo.
echo.
echo Backing up %DB_NAME% to %BK_FILE%...
echo.
echo.
sqlcmd -E -S %DB_HOSTNAME% -d master -Q "BACKUP DATABASE [%DB_NAME%] TO DISK = N'%BK_FILE%' WITH INIT , NOUNLOAD , NAME = N'%DB_NAME% backup', NOSKIP , STATS = 10, NOFORMAT"
echo.
echo Done!
echo.
pause