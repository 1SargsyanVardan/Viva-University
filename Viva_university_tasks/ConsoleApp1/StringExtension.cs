﻿using System;
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
        public static bool IsValidEmail(this string email)
        {
            if (email == null || email.Length == 0)
                return false;

            int indexOfShnik = email.IndexOf('@');
            bool isValid = true;
            for (int i = 0; i < indexOfShnik; i++)
            {
                if (email[i] >= 'a' && email[i] <= 'z')
                    continue;
                else if (email[i] == '.' || email[i] == '_')
                    continue;
                else if (email[i] >= '0' && email[i] <= '9')
                    continue;
                else
                {
                    isValid = false;
                    break;
                }

            }
            string afterShnik = string.Concat(email.Substring(++indexOfShnik));
            int indexOfDot = afterShnik.IndexOf('.');
            for (int i = 0; i < indexOfDot; i++)
            {
                if (afterShnik[i] >= 'a' && afterShnik[i] <= 'z')
                    continue;
                else if (afterShnik[i] >= '0' && afterShnik[i] <= '9')
                    continue;
                else
                {
                    isValid = false;
                    break;
                }
            }
            for (int i = indexOfDot + 1; i < afterShnik.Length; ++i)
            {
                if (afterShnik[i] <= 'a' || afterShnik[i] >= 'z')
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
        public static string Trim(this string str)
        {
            int start = 0;
            int end = str.Length - 1;
            if (str == null || str.Length == 0)
                return str;
            while (start <= end && str[start].Equals(" ")) ;
            {
                start++;
            }
            while (end >= start && str[start].Equals(" ")) ;
            {
                end--;
            }
            return str.Substring(start, end);
        }
        public static bool FileExists(this string filePath)
        {
            return File.Exists(filePath);
        }
        //helping with chatGPT
        public static T ToEnum<T>(this string str) where T : Enum
        {
            return (T)Enum.Parse(typeof(T), str);
        }
        public static string FormatPhoneNumber(this string str)
        {
            if (str == null)
                return "The phone number field is empty";
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] < '0' || str[i] > '9')
                {
                    return "This isn`t Phone number,Please Enter Valid number";
                    break;
                }
            }
            if (str.Length != 11 || str.Substring(0, 3) != "374")
                return "The phone number isn`t Armenian";

            string newPhoneNumber = $"(+{str.Substring(0, 3)})-{str.Substring(3, 2)}-{str.Substring(5, 3)}-{str.Substring(8, 3)}";
            return newPhoneNumber;

        }
    }
}
