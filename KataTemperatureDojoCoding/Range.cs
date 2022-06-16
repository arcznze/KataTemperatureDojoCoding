using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTemperatureDojoCoding
{
    public class Range
    {
        public object text;

        public Range(object text)
        {
            this.text = text;
        }

        string FirstNumber(string x)
        {
            string a = x.Substring(2, 1);
            return a;
        }
        string SecondNumber(string x)
        {
            string a = x.Substring(4, 1);
            return a;
        }
        string FirstChar(string x)
        {
            string a = x.Substring(1, 1);
            return a;
        }
        string SecondChar(string x)
        {
            string a = x.Substring(1, 1);
            return a;
        }
        string GetAllPoint(string x)
        {
            Range text = new Range(x);
            if (FirstChar(x) == "[")
            {
                return a;

            }
            else
            {
                return t;

            }
            if (SecondChar(x) == "(")
            {
                return a;
            }
            else
            {
                return t;

            }
        }
        string Equals(string x)
        {
            Range text = new Range(x);
            if (FirstChar(x) == "[")
            {
                return a;

            }
            else if ()
            else
                    {
                        return t;

                    }
            if (SecondChar(x) == "(")
            {
                return a;
            }
            else
            {
                return t;

            }


        }







    }



}
