using System;

namespace Strings_Omalley_Lauren
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user to input a character then assigns the input to a variable
            Console.WriteLine("Please input a character!");
            char myChar = Console.ReadKey().KeyChar;

            // Checks if the character that the user entered is a letter
            bool isLetter = Char.IsLetter(myChar);

            // Shows the results to the console
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}.");

            // Asks the user a question and then saves the response to a varialbe called sentence
            Console.WriteLine("Why do you like video games?");
            string sentence = Console.ReadLine();

            // Asks the user to enter a word then saves the response to a variable called word
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();

            // Checks if the word is in the sentence
            bool isIn = sentence.Contains(word);

            // Shows if the word is in the sentence
            Console.WriteLine($"{word} exists in {sentence}, {isIn}!");
        }
    }
}
