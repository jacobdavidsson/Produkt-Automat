namespace Produkt_Automat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Food> foods = new List<Food>();
            foods.Add(new Food("Ost & skinkmacka", "Macka med ost och skinka", 39));
            foods.Add(new Food("Proteinbar Salty Peanut", "Proteinbar med smak av saltade jordnötter", 25));
            foods.Add(new Food("BBQ Sandwich", "Sandwich med grillad kyckling och BBQ smak", 59));

            List<Drinks> drinks = new List<Drinks>();
            drinks.Add(new Drinks("Coca-Cola", "Läsk med Cola smak", 20));
            drinks.Add(new Drinks("Drickkvarg Mango", "Drickkvarg med 20g protein med smak av mango", 25));
            drinks.Add(new Drinks("Fanta", "Läsk med Apelsin smak", 20));

            List<Wearables> wearables = new List<Wearables>();
            wearables.Add(new Wearables("Nike Keps", "Svart keps med märket Nike", 299));
            wearables.Add(new Wearables("Armbandsur", "Sportklocka från Adidas", 499));
            wearables.Add(new Wearables("Svettband", "Träningsband för att ta bort svetten från pannan", 99));
        }
    }
}