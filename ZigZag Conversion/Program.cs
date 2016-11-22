//https://leetcode.com/problems/zigzag-conversion/
//Accepted
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZag_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*               
             * I AM GONNA USE THE EXAMPLE "X" (a~z), AND NUMBER OF ROWS IS 4
             * THE ANSWER LOOKS LIKE BELOW:
             * 
             * a    g    m    
             * b  f h  l n    
             * c e  i k  o    
             * d    j    p
             * 
             * I THINK WE CAN USING SIX CHARs FOR A LOOP (a to f), 
             * THE PROPLEMs WILL BE:
             * 1. HOW TO DESIGN THE CORRECT LOOP?
             * 2. WHAT'S THE MAGIC NUMBER OF "CHARs"? WHAT'S THE EFFECT OF THIS NUMBER?
             * 3. STORE VARIABLES.
             */

            string x = "abcdefghijklmnopqrstuvwxyz";
            Convert(x, 4);

            Console.Read();
        }

        static string Convert(string s, int numRows)
        {
            // return excepted raw string.
            if (s.Length <= numRows || numRows < 2)
            {
                return s;
            }

            string[] _str = new string[numRows];
            int row_id = 0;
            char[] _s = s.ToArray();
            int gap = numRows * 2 - 2;
            
            for (int i = 0; i < _s.Length; i = i + gap)
            {
                row_id = 0;

                for (int j = 0; j < gap; j++ )
                {
                    // 0 1 2 3 2 1
                    // adjust index of row
                    if (j >= _str.Length)
                    {
                        row_id = gap - j;
                    }

                    // prevent index out of range
                    if ((j + i) >= _s.Length)
                    {
                        break;
                    }

                    // append _s[j+i] to respond string
                    _str[row_id] += _s[j + i];

                    // using next string (if no need to adjust the index!)
                    row_id++;
                }
            }

            // build the answer.
            for (int i = 1; i < _str.Length; i++)
            {
                _str[0] += _str[i];
            }

            //Console.WriteLine("_str[0]=" + _str[0]);
            return _str[0];
        }
    }
}
