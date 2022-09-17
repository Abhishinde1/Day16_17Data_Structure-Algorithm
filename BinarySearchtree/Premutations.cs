using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchtree
{
    internal class Permutations
    {
        public static string SwapChar(string array, int startChar, int endChar)
        {
            char temp;
            char[] charArray = array.ToCharArray();
            temp = charArray[startChar];
            charArray[startChar] = charArray[endChar];
            charArray[endChar] = temp;
            string newStringForm = new string(charArray);
            return newStringForm;

        }

    }
    }
