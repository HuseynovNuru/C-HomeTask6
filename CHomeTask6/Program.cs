using System;

namespace CHomeTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş yazıda rəqəm olub olmadığını tapan metod
            string letter = "Nuru";
            Console.WriteLine(HaveNum(letter));


            //Verilmiş yazının fullname olub olmadığını tapan metod
            string fullname = "Huseynov Nuru";
            Console.WriteLine(IsFullName(fullname));


            //Verilmiş ədədlər siyahısından yeni bir array düzəldib qaytaran metod.Yeni arrayə elementlər təkrarlanmamaq şərti ilə yerləşdirilsin.
            int[] number = { 12, 24, 25, 12, 24, 34, 44 };
            var result = UniqeArr(number);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }


            //Verilmiş email-lər siyahısından domainlər siyahısı düzəldən metod.Domainlər arrayində təkrarlanmamlıdır domainlər!
            string[] email = { "huseynov@gmail.com", "nuru@mail.ru" };
            var resultmail = DomainMail(email);
            for (int i = 0; i < resultmail.Length; i++)
            {
                Console.WriteLine(DomainMail(email));
            }
            
        }


        //Verilmiş yazıda rəqəm olub olmadığını tapan metod
        static bool HaveNum(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return false;
                }
            }
            return true;
        }

        //Verilmiş yazının fullname olub olmadığını tapan metod
        static bool IsFullName(string str)
        {
            int wordCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    wordCount++;
                }
            }
            if (wordCount < 2)
            {
                var words = str.Split(' ');
                if (IsFullName(words[0]) && IsFullName(words[1]))
                {
                    return true;
                }
            }
            return false;
        }

        //Verilmiş ədədlər siyahısından yeni bir array düzəldib qaytaran metod.Yeni arrayə elementlər təkrarlanmamaq şərti ilə yerləşdirilsin.
        static int[] UniqeArr(int[] arr)
        {
            int[] newArr = new int[0];
           for (int i = 0; i < arr.Length; i++)
           {  
                if (Array.IndexOf(newArr, arr[i]) == -1)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = arr[i];
                }
           }
            return newArr;
        }

        //Verilmiş email-lər siyahısından domainlər siyahısı düzəldən metod.Domainlər arrayində təkrarlanmamlıdır domainlər!
        static string[] DomainMail(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Substring(arr[i].IndexOf('@') + 1);
            }
            var result = new string[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(Array.IndexOf(result, arr[i]) == -1)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = arr[i];
                }
            }
            return result;
        }

    }
}
