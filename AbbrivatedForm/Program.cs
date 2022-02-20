using System;

namespace AbbrivatedForm
{
    class program
    {

        public static void printInitials(string str)
        {
            int len = str.Length;

            String t = "";
            for (int i = 0; i < len; i++)
            {
                char ch = str[i];

                if (ch != ' ')
                {
                    t = t + ch;
                }
                else
                {
                    Console.Write(Char.ToUpper(t[0]) + ". "); t = "";
                }
            }

            string temp = "";
            for (int j = 0; j < t.Length; j++)
            {
                if (j == 0)
                    temp = temp + Char.ToUpper(t[0]);
                else
                    temp = temp + Char.ToLower(t[j]);
            }

            Console.WriteLine(temp);
        }

        public static void Main()
        {
            Console.WriteLine("Enter any string");

            string str = Console.ReadLine();
            printInitials(str);
        }
  
    }
}