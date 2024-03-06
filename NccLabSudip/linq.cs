using System;
using System.Linq;
using System.Text;

namespace NccLabSudip
{
    class linq
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 5, 2, 7, 9, 1 };

            var result = from data in arr where data > 5 select data;
            Console.WriteLine("element greater than 5 are");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
