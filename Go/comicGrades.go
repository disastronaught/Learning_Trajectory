//I do have a first edition Vol. 2 Gorr comic, but Spawn is still like $40 per book, so I'm holding off on those. 
//This program is to store the details and grade of thing. Just thinking about sending out all of the 
//comics I need a grading for is stressing me out. 

package main

import "fmt"

func main(){
  publisher, writer, artist, title := "DC", "Todd", "Ray", "Spawn"
  year, pageNumber := 2006, 21
  grade := 8.8

  fmt.Println(title, "written by", writer, "drawn by", artist, "published by", publisher, "written in the year", year, "on page number ", pageNumber, "it get's dicey", " this specific edition has an official quality grade of", grade)

  title, writer, artist, publisher = "Gorr Vol. 2", "Stan", "Dan", "Marvel"
  year= 2014
  pageNumber = 6
  grade = 9.1

  fmt.Println(title, "written by", writer, "drawn by", artist, "published by", publisher, "written in the year", year, "on page number ", pageNumber, "it get's interesting", " this specific edition has an official quality grade of", grade)

}
