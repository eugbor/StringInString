using System;

namespace StringInString
{
    class Program
    {
        /// <summary>
        /// Поиск всех вхождений строки в строку.
        /// </summary>
        static void Main(string[] args)
        {
            var s1 = "abacabaab";
            var s2 = "ab";
            
            //int index = 0;
            //while (index != -1)
            //{
            //    index = s1.IndexOf(s2);
            //    if(index!=-1)
            //        Console.WriteLine(index);
            //    if (!(index < 0))
            //    {
            //        string s3 = s1.Remove(index, 2);
            //        string s4 = s3.PadLeft(s1.Length);
            //        s1 = s4;
            //    }
            //}

            int i = 0;
            int j = 0;
            while (i < s1.Length)
            {
                Console.WriteLine($"{s1[i]} {s2[j]}");
                if (s1[i] == s2[j])
                {
                    i++;
                    j++;
                    if (j == s2.Length)
                    {
                        Console.WriteLine(i-s2.Length);
                        j = 0;
                    }
                }

                else
                {
                    if (j == 0)
                    {
                        i++;
                    }
                    j = 0;
                    
                }
            }
                Console.ReadLine();
        }
    }
}
