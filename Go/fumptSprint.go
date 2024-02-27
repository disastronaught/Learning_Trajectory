//Silently conducting string concatonation and interpolation is also, awesome.
//This is really intruiging when you think about the uses is managing the future output of larger and more maleable data sets.
package main

import "fmt"

func main() {
  step1 := "Breathe in..."
  step2 := "Breathe out..."
  
  // Add your code below:
  meditation := fmt.Sprintln(step1, step2)
  fmt.Print(meditation)
}
