# little helper script to delete all .meta files that are created
# when I load this template on unity. these should not be commited since
# this is a template and the guids would also be duplicated.

$directoryPath = Get-Location
$files = Get-ChildItem -Path $directoryPath -Recurse -File -Include *.meta

foreach ($file in $files)
{
    Remove-Item -Path $file.FullName
}