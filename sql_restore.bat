@echo off
echo -- RESTORE DATABASE --
set DATABASENAME=QLKTX
set BACKUPFILENAME=%DATABASENAME%.bak
set SERVERNAME=(local)

:: WARNING - delete the database, suits me
sqlcmd -E -S %SERVERNAME% -d master -Q "IF EXISTS (SELECT * FROM sysdatabases WHERE name=N'%DATABASENAME%' ) DROP DATABASE [%DATABASENAME%]"
sqlcmd -E -S %SERVERNAME% -d master -Q "CREATE DATABASE [%DATABASENAME%]"

:: restore
sqlcmd -E -S %SERVERNAME% -d master -Q "RESTORE DATABASE [%DATABASENAME%] FROM DISK = N'%CD%\%BACKUPFILENAME%' WITH REPLACE"

:: remap user/login (http://msdn.microsoft.com/en-us/library/ms174378.aspx)
:: sqlcmd -E -S %SERVERNAME% -d %DATABASENAME% -Q "sp_change_users_login 'Update_One', 'login-name', 'user-name'"
:: sqlcmd -E -S %SERVERNAME% -d master -Q "ALTER DATABASE [%DATABASENAME%] SET MULTI_USER"
echo.
pause