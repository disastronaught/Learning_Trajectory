Write-Host "Welcome, travelers!"

[Int]$original_number = Read-Host -Prompt "Type a number, any number"
$number = $original_number

$number *= 3
$number += 6
$number /= 3
$number -= $original_number
$number --

Write-Host "The final number is $number."
Write-Host "Is it 1? Magic!"
