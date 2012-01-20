@echo off

rem Ensure structure exists
if not exist input\tools mkdir input\tools
if not exist input\lib mkdir input\lib
if not exist input\content mkdir input\content

echo Updating files...
for /f "eol=# tokens=1,2" %%I in (files.lst) do xcopy /y ..\%%I input\%%J

echo Packaging...
nuget pack package.nuspec -BasePath input -OutputDirectory output 


