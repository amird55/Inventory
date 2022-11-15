using System;
using System.Collections.Generic;
using System.Text;
namespace liam_lo_yahil
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, int> pleasework = Part.ziv(2, 6);
            foreach (var item in pleasework)
            {
                Console.WriteLine("key= {0}, value={1}",item.Key,item.Value);
            }


        }
    }
}
