//Ok, I'm liking this. Go uses some things with declarations which are reminiscent of lambda statements from C# with it's variable declarations
//which make the code read really cleanly and clearly. This is fast.

package main

import "fmt"

func main () {
  // Define magicNum and powerLevel below:
  var magicNum, powerLevel int32

  magicNum = 2048
  powerLevel = 9001
  
  fmt.Println("magicNum is:", magicNum, "powerLevel is:", powerLevel)
  
  
  // Define amount and unit below:
  amount, unit := 10, "doll hairs"
  
  fmt.Println(amount, unit, ", that's expensive...")
}
