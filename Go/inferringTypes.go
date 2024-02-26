//I was wondering when this little gem would come about in the lessons
//Go circumvents assigning static data types with an included operator ':=' which detects the variable and assigns it based on user input
//This might help, might hurt, because integers are assinged uint32 or uint64 automatically, which consumes more memory that necessary
package main

import "fmt"

func main() {
  // Define daysOnVacation using := below:
  daysOnVacation := 7
  
  // Define hoursInDay using var and = below:
  var hoursInDay = 24
  
  fmt.Println("You have spent", daysOnVacation * hoursInDay, "hours on vacation.")
}
