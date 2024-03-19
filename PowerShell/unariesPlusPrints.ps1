$expression_1 = 5 % (2 + 4 * 2) - 1
$expression_2 = (5 * 4) % (3 * (2 + 1))
$expression_3 = 3 + (2 -ne 5) -and (2 * 5 -gt 8)

Write-Host "Expression 1 returns: $expression_1"
Write-Host "Expression 2 returns: $expression_2"
Write-Host "Expression 3 returns: $expression_3"
