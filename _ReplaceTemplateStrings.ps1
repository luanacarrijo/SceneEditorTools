$curr = Read-Host -Prompt 'Current'
$new  = Read-Host -Prompt 'New'

$directoryPath = Get-Location
$files = Get-ChildItem -Path $directoryPath -Recurse -File

foreach ($file in $files)
{
  if ($file.Extension -eq '.ps1')
  {
    continue
  }

  $filePath = $file.FullName
  
  $content = Get-Content -Path $filePath -Raw
  if ($content -cmatch $curr)
  {
    $newContent = $content -creplace $curr, $new
    Set-Content -Path $filePath -Value $newContent -NoNewline
  }
  
  $fileName = $file.Name
  if ($fileName -cmatch $curr)
  {
    $newName = $fileName -creplace $curr, $new
    Rename-Item -Path $filePath -NewName $newName
  }
}
