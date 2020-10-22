using System;

namespace Prog2prov
{
    public class Book
    {

        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator;


        public Book()
        {
            
            rarity = generator.Next(0,100);
            actualValue = generator.Next(0,100);
            cursed = int.TryParse (generator.Next(0,100), out int);



        }

        public void Printinfo()
        {

        }

        public int Evaluate()
        {
            price = rarity*actualValue;

        }

        public string GetCategory()
        {
            System.Console.WriteLine(category);
        }

        public string GetName()
        {
            System.Console.WriteLine(name);
        }

        public bool IsCursed()
        {
            
        }

    }


}
