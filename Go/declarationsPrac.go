//while the declarations may seem "out of order" at this point, it's all the same in the sense that the same information is passed
//into the vaiables. One thing I like about Go so far, is the ability to state the size of the variables far more accurately and with
//less typed characters
//instead of using long/short/4word and so on we can just use ui32..ui8 or ui64 to state the binary length of memory consumed
package main

import "fmt"

func main() {
  var numOfFlavors int

  numOfFlavors = 57
  
  fmt.Println(numOfFlavors)
  

  var flavorScale float32 = 5.8
  fmt.Println(flavorScale)

}
