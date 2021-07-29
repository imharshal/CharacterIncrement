using System;

namespace CharacterIncrement
{
    class Program
    {
        static void Main(string[] args)
        {
            string str,strNew;
            strNew = "";
            int i, l;
            i = l = 0;
            Console.WriteLine("Enter a string");
            str = Console.ReadLine();
            l = str.Length;

            while (i < l)
            {
                strNew += Convert.ToChar( str[i] + 1);
                i++;
            }
            Console.WriteLine(strNew);

        }
    }
}
