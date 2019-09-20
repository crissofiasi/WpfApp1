using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public static class Extensionscs
    {


        public static List<int> textToNumbers(this string text)
        {
            string[] words = text.Split(' ');
            List<int> ret = new List<int>();
            int numar;

            foreach (string word in words)
            {
                if (word.Length != 0)
                {

                    bool IsOK = int.TryParse(word, out numar);
                    if (IsOK)
                    {
                        ret.Add(numar);
                    }
                    else
                    { return null; }

                }
            }   

            return ret;

        }

        public static int getLetterCount(this string c)
        {
            int maxLeters = c.Trim().Length;
            for (int i = 0; i < c.Trim().Length; i++)
            {
                if (c[i] == ' ')
                {
                    maxLeters--;
                }
            }
            int distinctLeters = maxLeters;
            List<char> letters = c.ToUpper().ToCharArray().ToList();
            for (int i = 0; i < maxLeters; i++)
            {
                char chr = letters[i];
                if (letters.LastIndexOf(chr) > i)
                    distinctLeters--;
            }

            return distinctLeters;

        }




    }
}
