using System;
using System.Collections.Generic;

namespace Prog2prov
{
    public class Book
    {

        List<string> names = new List<string>() {"One", "Two", "Three", "Four", "Five"};
        List<string> categories = new List<string>(){"Drama", "Action", "Comedy", "Tragedy", "History"};
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
            cursed = int.TryParse (generator.Next(0,100), out );

        }

        //Skriver ut info om boken, med syfte att flrklara för användaren vilken typ av bok den har framför sig.
        public void Printinfo()
        {
            Console.Write(name, rarity, category, price);
        }

        //Skriver bokens faktiska värde
        public int Evaluate()
        {
            price = rarity*actualValue/10;

            int realPrice = generator.Next(5, 15) * price;

            return realPrice;

        }

        //Returnerar kategorin boken har
        public string GetCategory()
        {
            return category;
        }

        //Returnerar namnet boken har
        public string GetName()
        {
            return name;
        }

        //Returnerar antingen true eller false och har 80% chans att den returnerar samma värde som i variabeln cursed, med 20% chans att returnera motsatt värde.
        public bool IsCursed()
        {
            return cursed;
        }

    }


}
