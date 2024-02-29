//If we increment something in a function but we call that function from outside of its scope (in func main())
//then we'll see no incremental change to the variable we called the function for.
//We need to use a pointer to reference where we'll be making the change.
//This is seen where we're using '*' on the output stated in the function signature 

package main

import "fmt"
//the next line is where we can see the signature changed to include a returned address "*string" instead of just 'string'
func brainwash(saying *string) {
	// then we state the address of the variable where it's then called in the main() function
	*saying = "Beep Boop."
}

func main() {
	greeting := "Hello there!"
	
	brainwash(&greeting)
	fmt.Println("greeting is now:", greeting)
}
