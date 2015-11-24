using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringApplication
{
    class Utils
    {
        private static readonly Regex VOWEL_CHAR = new Regex("[aoeiuy]");

        //Prints menu in console.
        public static void printMenu()
        {

            Console.WriteLine("------------------------------Menu------------------------------\n"
              + "1. Add strings\n"
              + "2. Sort list of strings by count of vowels in string\n"
              + "0. Exit\n"
              + "----------------------------------------------------------------\n");
        }

        //Adds new string entered from keyboard to the List.
        public static void addString(List<string> stringList)
        {
            Console.WriteLine("Enter a new string");
            string newString = Console.In.ReadLine().ToLower();
            if (newString.Length != 0)
            {
                stringList.Add(newString);
                Console.WriteLine("New string added\n");
            }
            else
            {
                Console.WriteLine("New string hasn't been added. Unable to add an empty string\n");
            }
        }

        //Sorts List of strings by number of vowel characters. 
        public static List<StringObject> sortListByVowel(List<string> stringList)
        {
            List<StringObject> sortedStringList = new List<StringObject>();
            foreach (string str in stringList)
            {
                int count = VOWEL_CHAR.Matches(str).Count;
                sortedStringList.Add(new StringObject(count, str));
            }
            sortedStringList.Sort(delegate (StringObject s1, StringObject s2)
            {
                return s1.vowelElement.CompareTo(s2.vowelElement);
            });
            sortedStringList.Reverse();
            return sortedStringList;
        }

        //Prints sorted List of strings and number of its vowel characters.
        public static void printReport(List<StringObject> stringItemList)
        {
            foreach (StringObject strItem in stringItemList)
            {
                Console.WriteLine(strItem.toStringWithVowel());
            }
            Console.WriteLine("\n");
        }
    }
}

