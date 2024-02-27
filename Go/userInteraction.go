//The first Go project of the day. Practicing using fmt functions and passing user input to variables
package main

import (
  "fmt"
)

func main() {

var name string
fmt.Println("What's your name?")
fmt.Scan(&name)

fmt.Println("Hello", name)

var age int
fmt.Println("What is your age?")
fmt.Scan(&age)
fmt.Printf("Hi, %v you are %d years old.", name, age)

newMessage := fmt.Sprintf("This is %v and they are %d years old.", name, age)
fmt.Println(newMessage)
}
