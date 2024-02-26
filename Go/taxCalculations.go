//this is reflective of some standard practices with C languages, they really hammered on the use of '+=' and '*=' 
package main

import "fmt"

func main() {
  newShoes := 65.99
  newWatch := 45.50
  
  
  var taxCalculation float64
  
  taxCalculation += newShoes  
  
  taxCalculation += newWatch
  
  taxCalculation *= .08875
  
  fmt.Println("Purchase of", newShoes + newWatch, "with 8.875% sales tax", taxCalculation, "equal to", newShoes + newWatch + taxCalculation)
}
