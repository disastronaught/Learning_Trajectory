//using parameters within functions, we're passing in variables which can be used in the computation here
package main
import "fmt"


func computeMarsYears(earthYears int) int {
//here we pass in earthYears as an integer and stating what happens when computeMarsYears is called
  
  earthDays := earthYears * 365
  marsYears := earthDays / 687
  return marsYears
}

func main() {
  myAge := 25
  //we declare our starting point by passing in value to myAge
  
  myMartianAge := computeMarsYears(myAge)
  fmt.Println(myMartianAge)
  //then we make the function call using the computeMars years function and patting in myAge as a parameter for it
}
