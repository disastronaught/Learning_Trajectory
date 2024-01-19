using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
      string lowercase = "qwertyuiopasdfghjklzxcvbnm";
      string digits = "1234567890";
      string specialChars = "~`!@#$%^&*()_+-=[]{};'"; 
      Console.WriteLine("Enter a password: ");
      string password = Console.ReadLine();
      int score = 0;
    
      if (password.Length >= minLength)
        {
          score++;
        }
      if (Tools.Contains(password, "QWERTYUIOPASDFGHJKLZXCVBNM"))
        {
        score++;
        }
      if (Tools.Contains(password, "qwertyuiopasdfghjklzxcvbnm"))
        {
          score++;
        }
      if (Tools.Contains(password, "~`!@#$%^&*()_+-=[]{};'"))
        {
          score++;
        }
     Switch (score)
        {
          case 1:
            Console.WriteLine("Weak");
            break;
          case 2:
            Console.WriteLine("Medium");
            break;
          case 3:
            Console.WriteLine("Strong");
            break;
          case 4:
            Console.WriteLine("Extremely strong!");
            break;
          case 5:
            Console.WriteLine("Extremely Strong!");
            break;
          case 0:
            Console.WriteLine("Password cannot be all spaces");
            break;
        }
      Console.WriteLine(score);
 
        
    }
  }
}
