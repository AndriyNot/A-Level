namespace HomeWork8
{
    using System;
    using HomeWork8.Models;
    using HomeWork8.Services;

    public class Startup
    {
        public void Start() 
        {
            Console.WriteLine("Enter the weight of the gift?");
            int user = Convert.ToInt32(Console.ReadLine());

            GiftService giftService = new GiftService(user);
            giftService.CreateSweets();

            Random random = new Random();

            while (giftService.CalculateWeight(giftService.GiftSweets) < giftService.WeightLimit)
            {
                int randomIndex = random.Next(0, giftService.sweets.Length);
                ISweet randomCandy = giftService.sweets[randomIndex];
                giftService.AddSweet(randomCandy);
            }

            Console.WriteLine("The gift is created");
            Console.WriteLine($"Size of the gift:{giftService.CalculateWeight(giftService.GiftSweets)}");

            Console.WriteLine("Search for a candy by weight");

            Console.Write("Enter the minimum weight:");
            int minWeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the maximum weight");
            int maxWeight = Convert.ToInt32(Console.ReadLine());
            giftService.SerchGift(minWeight, maxWeight);

            Console.WriteLine("Get all the candies from the gift?");
            Console.WriteLine("Yes - 1|No - 2");

            user = Convert.ToInt32(Console.ReadLine());

            switch (user)
            {
                case 1:
                    foreach (var item in giftService.GiftSweets)
                    {
                        Console.WriteLine($"{item.Display()}");
                    }

                    break;

                case 2:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
