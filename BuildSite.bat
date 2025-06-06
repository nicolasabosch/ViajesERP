echo


set dir=C:\Proyectos\ViajesERP
cd %dir%


set tmptime=%time: =0%
rem Set today=%date:~6,4%%date:~3,2%%date:~0,2%-%tmptime:~0,2%%tmptime:~3,2%
Set today=%date:~11,4%%date:~8,2%%date:~5,2%-%tmptime:~0,2%%tmptime:~3,2%


del  Deploy%today% /F /Q
md Deploy%today%

set dir=C:\Proyectos\ViajesERP\
cd %dir%


dotnet publish ViajesERPAPI\ViajesERPAPI.sln --configuration Release -o C:\Proyectos\ViajesERP\Deploy%today%\FullNetCore\ --no-dependencies  --no-restore  --no-self-contained



copy C:\Proyectos\ViajesERP\Deploy%today%\FullNetCore\GCDNet*.dll C:\Proyectos\ViajesERP\Deploy%today%\
copy C:\Proyectos\ViajesERP\Deploy%today%\FullNetCore\CabernetDBContext.dll C:\Proyectos\ViajesERP\Deploy%today%\
	
set dir=C:\Proyectos\GeoLocation
cd %dir%

rem call npm install
set NODE_OPTIONS=--openssl-legacy-provider
ng build --configuration "production"  --sourceMap=false --aot --output-hashing=all --output-path=C:\Proyectos\ViajesERP\Deploy%today%\wwwroot





