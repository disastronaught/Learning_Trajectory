//I made this calculator for travel to places calculating if the fuelRemaining variable, passed between
//several functions, was enough to make the trip
package main

import "fmt"

// Create the function fuelGauge() here
func fuelGauge(fuel int) int{
fmt.Println(fuel)
return fuel
}

// Create the function calculateFuel() here
func calculateFuel(planet string, fuel int) (string, int){
fmt.Println(planet, fuel)

if planet == "Mercury"{
  fuel = 500000
} else if planet == "Venus" {
  fuel = 300000
} else if planet == "Mars" {
  fuel = 700000
} else {
  fmt.Println("you don't need fuel?")
}
return planet, fuel

}

// Create the function greetPlanet() here
func greetPlanet(planet string) string {
fmt.Println("Welcome to this world. -Les Claypool. Oh yeah, we're now approaching %v.")
return planet
}

// Create the function cantFly() here
func cantFly() {
fmt.Println("We do not have the available fuel to fly there.")
}

// Create the function flyToPlanet() here
func flyToPlanet(planet string, fuel int) (string, int) {
  var fuelRemaining, fuelCost int
  fuelRemaining = fuel
  planet, fuelCost = calculateFuel(planet, fuel)

  if fuelRemaining >= fuelCost {
    greetPlanet(planet)
    fuelRemaining -= fuelCost
  } else{
    cantFly()
    }
return planet, fuelRemaining
}

func main() {
  // Test your functions!
  
  // Create `planetChoice` and `fuel`
  fuel := 1000000
  planetChoice := "Venus"
  // And then liftoff!
  planetChoice, fuel = flyToPlanet(planetChoice, fuel)
  fuelGauge(fuel)
}
