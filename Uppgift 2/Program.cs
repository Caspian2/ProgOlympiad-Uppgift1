using System;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv en mening : ");
            string vanligaString = Console.ReadLine();
            char[] stringArray = vanligaString.ToCharArray();
            Array.Reverse(stringArray);
            string omvändaString = new string(stringArray);
            
        
            int wordCount = 0, index = 0;


            while (index < vanligaString.Length && char.IsWhiteSpace(vanligaString[index]))
            index++;

            while (index < vanligaString.Length)
            {
  
            while (index < vanligaString.Length && !char.IsWhiteSpace(vanligaString[index]))
            index++;

            wordCount++;


            while (index < vanligaString.Length && char.IsWhiteSpace(vanligaString[index]))
            index++;
            }

            Console.WriteLine($"Svar : {omvändaString} ");
            Console.WriteLine("Antal ord " + wordCount);
            Console.ReadLine();
        }  
    }
}
