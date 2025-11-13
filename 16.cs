using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicError3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Just making the array and then sortin the numbers
            int[] numbers = { 45, 12, 78, 34, 89, 23 };
            Array.Sort(numbers);
            Console.WriteLine(string.Join(", ", numbers));

            //In reverse or somethin like that
            Array.Reverse(numbers);
            Console.WriteLine(string.Join(", ", numbers));

            //Deletin the number 78 and printin the numbers
            var list = numbers.ToList();
            list.Remove(78);
            numbers = list.ToArray();
            Array.Sort(numbers);
            Console.WriteLine(string.Join(", ", numbers));

            // makin it try to see if the index of the number 34 exists or not if it exists then it will just print it out :P
            int indexOf34 = Array.IndexOf(numbers, 34);
            if (indexOf34 >= 0)
            {
                Console.WriteLine(indexOf34);
            }
            else
            {
                Console.WriteLine("doesnt exist");
            }

            Console.ReadLine();
        }

    }
}