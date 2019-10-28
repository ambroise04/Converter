using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertisseurRomain
{
    public class Converter
    {
        private readonly static Tuple<int, string>[] TuplesCasParticuliers =
        {
            new Tuple<int, string>(1000, "M"),
            new Tuple<int, string>(900, "CM"),
            new Tuple<int, string>(500, "D"),
            new Tuple<int, string>(400, "CD"),
            new Tuple<int, string>(100, "C"),
            new Tuple<int, string>(90, "XC"),
            new Tuple<int, string>(50, "L"),
            new Tuple<int, string>(40, "XL"),
            new Tuple<int, string>(10, "X"),
            new Tuple<int, string>(9, "IX"),
            new Tuple<int, string>(5, "V"),
            new Tuple<int, string>(4, "IV"),
            new Tuple<int, string>(1, "I"),
        };

        public static string GetRoman(int chiffre)
        {
            StringBuilder chiffreRomain = new StringBuilder();
            int i = 0;
            while (chiffre > 0 &&  i < TuplesCasParticuliers.Length)
            {
                int temp = 0;
                if (chiffre >= TuplesCasParticuliers[i].Item1)
                {
                    temp = (Int32)(chiffre / TuplesCasParticuliers[i].Item1);
                    chiffre = (Int32)(chiffre % TuplesCasParticuliers[i].Item1);

                    for (int j = 0; j < temp; j++)
                    {
                        chiffreRomain.Append(TuplesCasParticuliers[i].Item2);
                    }
                }
                i++;
            }
            
            return chiffreRomain.ToString();
        }
    }
}
