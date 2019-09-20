using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Cuvant
    {
        private string c;


        public Cuvant(string c1)
        {
            this.c = c1;
        }

        public bool IsPalindrom()
        {
            bool ret = true;
            for (int i = 0; i <= this.c.Length / 2; i++)
            {
                if (this.c.ToUpper().Trim()[i] != this.c.ToUpper().Trim()[this.c.Length - i - 1])
                {
                    ret = false;
                    break;
                }
            }

            return ret;
        }



        public string generateHello()
        {
            return "Hello, " + c + "!" + " Numele tau are " + this.c.getLetterCount().ToString() + " litere distincte.";
        }

    }
}
