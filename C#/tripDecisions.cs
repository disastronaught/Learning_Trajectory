using System;

namespace LogicalOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      bool beach = true;
      bool hiking = false;
      bool city = true;
      
      bool yourNeeds = (beach && city);
      bool friendNeeds = (beach || hiking);
      bool barcelona = (city && beach);

      bool tripDecision = barcelona && (yourNeeds && friendNeeds);
      Console.WriteLine(tripDecision);
    }
  }
}


