//So this was an eye opener
//Most development projects and suites don't go into broad detail or cover very "deeply" the meaning of appendation of characters to function statements.
//The Go course covers the difference in formatting strings pretty widely. The uses of string interpolation with the "fmt" package was awesome.
package main

import "fmt"

func main() {
  animal1 := "cat"
  animal2 := "dog"
  
  // Add your code below:
  fmt.Printf("Are you a %v or a %v person?", animal1, animal2)
}
