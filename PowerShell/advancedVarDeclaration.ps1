[Int] $num_1 = 42
[Int] $num_2 = "forty two"
$name, $color, $date = "Ogon", "red", (Get-Date).DateTime
$date_data_type = $date.GetType().Name

Write-Host "Value of num_1 is $num_1"
Write-Host "Hello, my name is $name!"
Write-Host "My favorite color is $color."
Write-Host "Today is $date"
Write-Host "The data type for 'date' is '$date_data_type'`n"
