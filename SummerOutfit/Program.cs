class SummerOutfit
{
    public static void Main(String[] args)
    {
        int temperature = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();

        if (timeOfDay == "Morning")
        {
            if (temperature >= 10 && temperature <= 18)
            {
                string clothing = "Sweatshirt";
                string shoes = "Sneakers";
                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
            }
            else if (temperature > 18 && temperature <= 24)
            {

                string clothing = "Shirt";
                string shoes = "Moccasins";
                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
            }
            else if (temperature >= 25)
            {

                string clothing = "T-Shirt";
                string shoes = "Sandals";
                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");

            }
        }

        if (timeOfDay == "Afternoon")
        {
            if (temperature >= 10 && temperature <= 18)
            {
                string clothing = "Shirt";
                string shoes = "Moccasins";
                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
            }
            else if (temperature > 18 && temperature <= 24)
            {

                string clothing = "T-Shirt";
                string shoes = "Sandals";
                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
            }
            else if (temperature >= 25)
            {

                string clothing = "Swim Suit";
                string shoes = "Barefoot";
                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
            }
        }

        if (timeOfDay == "Evening")
        {
            if (temperature >= 10 && temperature <= 18)
            {
                string clothing = "Shirt";
                string shoes = "Moccasins";
                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
            }
            else if (temperature > 18 && temperature <= 24)
            {

                string clothing = "Shirt";
                string shoes = "Moccasins";
                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
            }
            else if (temperature >= 25)
            {

                string clothing = "Shirt";
                string shoes = "Moccasins";
                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
            }
        }
        
    }
}