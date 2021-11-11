using System;
using System.Text;
namespace _8_II_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < s.Length; i++) 
            {
                if (char.IsDigit(s[i]))
                {
                    s.Remove(i, 1);
                }
            }
            Console.WriteLine(s);
        }
    }
}
