//We're getting into the pointer's, addresses and dereferencing poriton of the Go module.
//This is neat, because in routers and switches classes, traditionally, you'd teach the 
//binary-to-base10-to-binary-to-octaldecimal-to-binary-to-hex steps, to help students 
//understand how computational architechtures throw data around and streamline it for
//transmission. Here, we're using the Go compiler to dip into the addressing pool and 
//give us a register address for just where our variable is stored.
package main

import "fmt"

func main() {
	treasure := "The friends we make along the way."
	fmt.Println(&treasure)
}
