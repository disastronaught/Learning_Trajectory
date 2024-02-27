//Going a little further into interpolation using % with the fmt package we can see just how useful this is in managing the output of data within strings.
//Particularly '%.<value>f' as a verb casting. While choosing the accuracy of a printed digit we can call to the console some fairly pretty things.
package main

import "fmt"

func main() {
  floatExample := 1.75
  // Edit the following Printf for the FIRST step
  fmt.Printf("Working with a %T", floatExample) 
  
  fmt.Println("\n***") // Added for spacing
  
  yearsOfExp := 3
  reqYearsExp := 15
  // Edit the following Printf for the SECOND step
  fmt.Printf("I have %d years of Go experience and this job is asking for %d years.", yearsOfExp, reqYearsExp) 
  
  fmt.Println("\n***") // Added for spacing
  
  stockPrice := 3.50
  // Edit the following Printf for the THIRD step
  fmt.Printf("Each share of Gopher feed is $%.2f.", stockPrice) 
}
