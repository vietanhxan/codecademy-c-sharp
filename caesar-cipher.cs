using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.WriteLine("Please enter your secret message: ");
      string secretMsg = Console.ReadLine();
      
      char[] secretMessage = secretMsg.ToCharArray();
      
      char[] encryptedMessage = new char[secretMessage.Length];
      
      for (int i = 0; i < secretMessage.Length; i++)
      {
        char encryptedLetter = secretMessage[i];
        int indexChar = Array.IndexOf(alphabet, encryptedLetter);
        int encryptedIndexChar = (indexChar + 3) % 26;
        encryptedLetter = alphabet[encryptedIndexChar];
        encryptedMessage[i] = encryptedLetter; 
      }
      
      string encryptedStringMsg = String.Join("", encryptedMessage);
      Console.WriteLine(encryptedStringMsg);
    }
  }
}
