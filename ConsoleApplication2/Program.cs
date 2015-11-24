using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            const string addStr = "1";
            const string sortStr = "2";
            const string exit = "0";
            bool loop = true;

            List<string> stringList = new List<string>();

            while (loop)
            {
                Utils.printMenu();
                string selector = Console.In.ReadLine();

                switch (selector)
                {
                    case addStr:
                        Utils.addString(stringList);
                        break;

                    case sortStr:
                        List<StringObject> sortedStringList = Utils.sortListByVowel(stringList);
                        Utils.printReport(sortedStringList);
                        break;

                    case exit:
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Wrong command.\n");
                        break;
                }
            }
        }
    }
}
