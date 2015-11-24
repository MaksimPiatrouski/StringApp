using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApplication
{
    class StringObject
    {
        private int vowelNum;
        private string str;

        public StringObject(int vowelNum, string str)
        {
            this.vowelNum = vowelNum;
            this.str = str;
        }

        public int vowelElement
        {
            get { return vowelNum; }
            set { vowelNum = value; }
        }
        public string stringElement
        {
            get { return str; }
            set { str = value; }
        }

        public string toStringWithVowel()
        {
            return stringElement + " (" + vowelElement + " vowel letters)";
        }
    }
}
