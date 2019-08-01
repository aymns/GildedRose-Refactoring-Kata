using System;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var items = new ItemRepository().GetAll();


            for (var day = 0; day < 31; day++)
            {
                Console.WriteLine("-------- day " + day + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach (var item in items)
                {
                    System.Console.WriteLine(item);
                }
                Console.WriteLine("");
                GildedRose.UpdateQuality(items);
            }
        }
    }
}
