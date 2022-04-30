using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Frozen
        {
            string character;
            string gift;

            public Frozen (string _character, string _gift)
            {
                character = _character;
                gift = _gift;
            }

            public string Character
            {
                get { return character; }
            }

            public string Gift
            {
                get { return gift; }
            }


        }
        static void Main(string[] args)
        {
            List<Frozen> myFrozen = new List<Frozen>();
            string[] CharactersAndGiftsFromFile = GetDataFromFile();

            foreach (string line in CharactersAndGiftsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Frozen newFrozen = new Frozen(tempArray[0], tempArray[1]);
                myFrozen.Add(newFrozen);
            }

            foreach (Frozen CharactersAndGiftsFromList in myFrozen)
            {
                Console.WriteLine($"Character --> {CharactersAndGiftsFromList.Character}. Gift --> {CharactersAndGiftsFromList.Gift}");
                Console.WriteLine();
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Sander\Samples\Frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
