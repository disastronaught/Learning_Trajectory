//Making some quick appendations to our previous program which discerned what biome 
//belonged to what aspects of fauna, we're using some cleanup code here with get;set; properties

using System;

namespace BasicClasses
{
  class Forest
  {
    public int age;
    public string biome;
    
    public string Name
    {
      { get; set; }
    }
    
    public int Trees
    {
      {get; set;}
    }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
  }

}
