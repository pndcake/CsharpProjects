using System;

namespace PasswordChecker
{

  class Program
  {
    public static bool Contains(string target, string list)
    {
    return target.IndexOfAny(list.ToCharArray()) != -1;
    }
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "!@#$%^&*_()-+=?";
      int score = 0;

      Console.WriteLine("This programe will rate the strength of your password.");
      Console.Write("Enter a password: ");
      
      string password = Console.ReadLine();

      if (password.Length >= minLength){
        score++;
      }
      if (Contains(password, uppercase)){
        score++;
      }
      if (Contains(password, lowercase)){
        score++;
      }
      if (Contains(password, digits)){
        score++;
      }
      if (Contains(password, specialChars)){
        score++;
      }
      
      switch(score) {
        case 5:
          Console.WriteLine("Password is extremely strong");
          break;
        case 4:
          Console.WriteLine("Password is extremely strong");
          break;
        case 3:
          Console.WriteLine("Password is strong");
          break;
        case 2:
          Console.WriteLine("Password is medium");
          break;
        case 1:
          Console.WriteLine("Password is weak");
          break;
        default:
          Console.WriteLine("Password doesn't meet any standards");
          break;
      }
      //Console.WriteLine(score);
    }
  }
}