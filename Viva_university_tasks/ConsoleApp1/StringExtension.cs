using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    public static class StringExtension
    {
        public static string StringManipulation(this string str)
        {
            if (str == null)
                return "The string is haven`t arguments";
            //chatGPT
            /*TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(str);*/

            //implementation 
            string[] temp = str.Split(' ');
            for (int i = 0; i < temp.Length; i++)
            {
                char ch = char.ToUpper(temp[i][0]);
                string otherStr = temp[i].Substring(1).ToLower();
                temp[i] = ch + otherStr;
            }
            string retStr = string.Join(' ', temp);
            return retStr;
        }
    }
}