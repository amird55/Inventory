using System;
using System.Collections.Generic;
using System.Text;
namespace liam_lo_yahil
{
    class Program
    {
        static void Main(string[] args)
        {
            kits[] kit =3 new kits[4];
            kit[0] = new kits();
            kit[1] = new kits();
            kit[2] = new kits();
            kit[3] = new kits();
            cards[] card = new cards[4];
            card[0] = new cards();
            card[1] = new cards();
            card[2] = new cards();
            card[3] = new cards();
            
            IDictionary<int, int> pleasework = Part.ziv(2, 6,kit, card);
            
            foreach (var item in pleasework)
            {
                Console.WriteLine("key= {0}, value={1}",item.Key,item.Value);
            }


        }
    }
}
