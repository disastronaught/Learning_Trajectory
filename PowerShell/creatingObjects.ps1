$person = New-Object -TypeName PSCustomObject
$person | Add-Member -MemberType NoteProperty -Name "FirstName" -Value "ogon"
$person | Add-Member -MemberType ScriptMethod -Name "greeting" -Value {Write-Host "It stirs."}
$person.greeting()
