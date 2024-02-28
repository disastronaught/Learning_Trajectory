package main

import (
  "fmt"
  "math/rand"
  "time"
)

func main() {
rand.Seed(time.Now().UnixNano())

isHeistOn := true
eludedGuards := rand.Intn(100)

if eludedGuards >= 50{
  fmt.Println("Looks like you've managed to make it past the guards. Good job, but remember, this is the first step (this would've been a lot easier if you just manipulated the clock in the vault door with an RF transducer)")
}else if (isHeistOn == false){
  fmt.Println("Plan a better method of entry.")
}
openedVault := rand.Intn(100)
fmt.Println(isHeistOn)


if (isHeistOn == true && openedVault >= 70) {
  fmt.Println("Grab and Go.")
  switch leftSafely := 0; leftSafely{
    case 0:
      isHeistOn = false
      fmt.Print("Looks like we tripped the alarm. Time to go")
  }

} else if isHeistOn == false && (openedVault < 70) {
fmt.Println("The vault can't be opened.")
}
}
