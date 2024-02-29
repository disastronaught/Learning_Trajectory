//Right after the addressing module, where we discussed base16/hex and printing addresses using the compiler
//we get into using pointers to reference the variable address. 
package main

import "fmt"

func main() {
	star := "Polaris"
	starAddress := &star
  fmt.Println("The address of star is", starAddress)
}
