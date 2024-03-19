$USER = "ogon"
$Env:HOME

Write-Host "Greetings, $USER!"
Write-Host "Whatever number you start with, I will (possibly) morph it into 10 through the powers of mathematics!`n"

$original_number = Read-Host -Prompt "Type a number"
$final_number = $original_number
$final_number = $final_number + 5
$final_number = $final_number *= 3
$final_number = $final_number -= 15
$fianl_number = $final_number /= $original_number
$final_number = $final_number += 7

$number_is_10 = $final_number -eq 10

Write-Host "The number is equal to 10: $number_is_10"
Write-Host "The final number is $final_number"
