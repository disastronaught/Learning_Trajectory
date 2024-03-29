#As we go through the OOP portion and descriptions of this module, I'll be updating this commands list as a reference
#document I can use while coding in the powershell terminal

$var | Get-Member -MemberType Property

#This is used for printing the methods for this variable
$my_num | Get-Member -MemberType Method

#this means to me, that we can compare strings or integers, the first thing that comes to mind is a checksum
#likewise, we can probably use this to check hashes or longer formatted variables to each other instead of
#doing it digit by digit
$my_num.CompareTo(6)

#Here we're converting variables, in this case from an integer to a string.
$this_string = $my_num.ToString()

#If we need to know the type of a variable we can call the GetType() function like this 
$my_string.GetType().Name
