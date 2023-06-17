using System;

namespace CaesarCipher
{
  class Program
  {
    static char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
    //method to encrypt message 
    static void Encrypt() {
      Console.Write("Enter your message: ");
      string message = Console.ReadLine();
      message = message.ToLower();
      char[] secretMessage = message.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];
      for (int i = 0; i < secretMessage.Length; i++) {
        char letter = secretMessage[i];
        int position = Array.IndexOf(alphabet, letter);
        int newPosition = (position + 3) % 26;
        char newLetter = alphabet[newPosition];
        encryptedMessage[i] = newLetter;
      }
      string newStringMessage = String.Join("", encryptedMessage);
      Console.WriteLine(newStringMessage);
    }
    //method to decrypt message
   static void Decrypt() {
      Console.Write("Enter your message: ");
      string message = Console.ReadLine();
      message = message.ToLower();
      char[] secretMessage = message.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];
      for (int i = 0; i < secretMessage.Length; i++) {
        char letter = secretMessage[i];
        int position = Array.IndexOf(alphabet, letter);
        int newPosition = (position - 3) % 26;
        char newLetter = alphabet[newPosition];
        encryptedMessage[i] = newLetter;
      }
      string newStringMessage = String.Join("", encryptedMessage);
      Console.WriteLine(newStringMessage);
    }

    static void Main(string[] args)
    {

      Console.Write("Welcome Human, would you like to Decrypt or Encrypt your message? Please enter encrypt or decrypt: ");
      string input = Console.ReadLine();
      input = input.ToLower();
      if (input == "encrypt") {
        Encrypt();
      }
      else if (input == "decrypt") {
        Decrypt();
      }
      else {
        Console.WriteLine("Incorrect input, self-destruct sequence initiated in 3..2..1.");
      }
    }
  }
}