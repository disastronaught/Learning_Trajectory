//Naturally, we'd need to know how to dereference an address by means of pointer
//So here we're changing our star variable using a dereferencing pointer
package main

import "fmt"

func main() {
	star := "Polaris"
	
	starAddress := &star

	*starAddress = "Sirius"
  
  fmt.Println("The actual value of star is", star)
}
