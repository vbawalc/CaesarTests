using System;
namespace CaesarCipher
{

    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Type a string to encrypt:");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.Write("Enter your Key");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Encrypted Data");

            string cipherText = Converter.Encipher(UserString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Decrypted Data:");

            string t = Converter.Decipher(cipherText, key);
            Console.WriteLine(t);
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
