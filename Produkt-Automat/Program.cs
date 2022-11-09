using System;
using System.Security.Cryptography;

namespace Produkt_Automat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Listor med objekt
            Food f1 = new Food("Ost & skinkmacka", "Macka med ost och skinka", 39);
            Food f2 = new Food("Proteinbar Salty Peanut", "Proteinbar med smak av saltade jordnötter", 25);
            Food f3 = new Food("BBQ Sandwich", "Sandwich med grillad kyckling och BBQ smak", 59);

            List<Food> foods = new List<Food>();
            foods.Add(f1);
            foods.Add(f2);
            foods.Add(f3);

            Drinks d1 = new Drinks("Coca-Cola", "Läsk med Cola smak", 20);
            Drinks d2 = new Drinks("Drickkvarg Mango", "Drickkvarg med 20g protein med smak av mango", 25);
            Drinks d3 = new Drinks("Fanta", "Läsk med Apelsin smak", 20);

            List<Drinks> drinks = new List<Drinks>();
            drinks.Add(d1);
            drinks.Add(d2);
            drinks.Add(d3);

            Wearables w1 = new Wearables("Nike Keps", "Svart keps med märket Nike", 299);
            Wearables w2 = new Wearables("Armbandsur", "Sportklocka från Adidas", 499);
            Wearables w3 = new Wearables("Svettband", "Träningsband för att ta bort svetten från pannan", 99);
            
            List<Wearables> wearables = new List<Wearables>();
            wearables.Add(w1);
            wearables.Add(w2);
            wearables.Add(w3);

            Menu();

            void Menu()
            {
                //Meny layout
                Console.WriteLine("------------Meny-------------");
                Console.WriteLine("=============================");

                //Counter för antal items
                int count = 0;
                foreach (Food i in foods)
                {
                    count++;
                    Console.Write("{0}. {1}", count, i.Name);
                    Console.WriteLine(" {0}:-", i.Cost);
                }
                Console.WriteLine("=============================");
                foreach (Drinks i in drinks)
                {
                    count++;
                    Console.Write("{0}. {1}", count, i.Name);
                    Console.Write(" ");
                    Console.WriteLine("{0}:-", i.Cost);
                }
                Console.WriteLine("=============================");
                foreach (Wearables i in wearables)
                {
                    count++;
                    Console.Write("{0}. {1}", count, i.Name);
                    Console.Write(" ");
                    Console.WriteLine("{0}:-", i.Cost);
                }

                count++;
                Console.WriteLine("=============================");
                Console.WriteLine("{0}. Avsluta", count);
                Console.WriteLine();
                Console.Write("Vad vill du köpa: ");
                var input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch(input)
                {
                    case 1:
                        Console.WriteLine(f1.Desc);
                        Console.WriteLine("Vill du köpa för {0} kronor?", f1.Cost);
                        Console.Write("1: Ja, 2: Nej : ");
                        var x = Console.ReadLine();
                        if (x == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Du köpte {0} för {1} kronor", f1.Name, f1.Cost);
                            Console.WriteLine("Vill du köpa något mer: ");
                            Console.Write("1: Ja, 2: Nej. : ");
                            var y = Console.ReadLine();
                            if (y == "1")
                            {
                                Console.Clear();
                                Menu();
                            }
                            else break;

                        }
                        else if (x == "2")
                        {
                            Console.Clear();
                            Menu();
                        }
                        else 
                        {
                            Console.Clear();
                            Console.WriteLine("Du måste svara med 1 eller 2!");
                            Console.WriteLine("");
                            Menu();
                        }
                        break;
                }
            }
        }
    }
}