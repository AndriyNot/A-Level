namespace HomeWork8.Services
{
    using System;
    using HomeWork8.Models;

    public class GiftService : IGift
    {
        public ISweet[] sweets { get; set; }

        public ISweet[] GiftSweets { get; set; }

        public int sweetsCount { get; set; }

        public int WeightLimit { get; set; }

        public GiftService(int weightLimit) 
        {
            sweetsCount = 0;
            sweets = CreateSweets();
            GiftSweets = new ISweet[12];
            WeightLimit = weightLimit;
        }

        public void AddSweet(ISweet sweet)
        {
            int totalWeigh = CalculateWeight(GiftSweets);

            if (totalWeigh < WeightLimit)
            {
                GiftSweets[sweetsCount++] = sweet;
            } 
        }

        public int CalculateWeight(ISweet[] sweets) 
        {
            int totalWeight = 0;
            foreach (ISweet sweet in sweets)
            {
                if (sweet != null)
                {
                    totalWeight += sweet.Weight;
                } 
            }

            return totalWeight;
        }

        public ISweet[] CreateSweets()
        {
            return new ISweet[]
            {
                new Candy("MilkyWay", 20, "Chocolate", "coconut"),
                new Candy("Toffix", 15, "Chewing gum", "apple"),
                new Candy("Ferrero Rocher", 12, "Chocolate", "nut"),

                new Chocolate("Milka", 150, "Milka", 10),
                new Chocolate("Schogetten", 100, "Schogetten", 12),
                new Chocolate("Lacmi", 87, "roshen", 5),

                new FilledChocolate("Milka", 250, "Milka", 8, "Oreo"),
                new FilledChocolate("Milka", 300, "Milka", 8, "Toffee"),
                new FilledChocolate("Milka", 300, "Milka", 8, "Strawbery Cheesecake"),

                new GummyBear("Haribo", 150, "jellies", "Apple", "MixColor"),
                new GummyBear("Yummi Gummi", 70, "jellies", "Orange", "Red"),
                new GummyBear("Trolli", 100, "jellies", "taste mix", "MixColor"),
            }; 
        }

        public void SerchGift(int MinWeight, int MaxWeight)
        {
            foreach (var item in GiftSweets)
            {
                if (item != null && item.Weight > MinWeight && item.Weight < MaxWeight)
                {
                    Console.WriteLine(item.Display());
                }
                else 
                {
                    Console.WriteLine("No candies found based on these criteria");
                    break;
                }
            }
        } 
    }
}
