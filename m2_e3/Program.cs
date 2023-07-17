namespace Module2_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Candy candy1 = new Candy("Candy1", 20, "Watermelon");
            Candy candy2 = new Candy("Candy2", 15, "Banana");
            Candy candy3 = new Candy("Candy3", 10, "Shrek");

            Chocolate chocolate1 = new Chocolate("Chocolate1", 50, "Poroshenko");
            Chocolate chocolate2 = new Chocolate("Chocolate2", 30, "Zelenskiy");
            Chocolate chocolate3 = new Chocolate("Chocolate3", 40, "Svitoch");

            Lollipop lollipop1 = new Lollipop("Lollipop1", 5, "Yellow");
            Lollipop lollipop2 = new Lollipop("Lollipop2", 8, "Black");
            Lollipop lollipop3 = new Lollipop("Lollipop3", 7, "Orange");

            Sweet[] gift = { candy1, candy2, candy3, chocolate1, chocolate2, chocolate3, lollipop1, lollipop2, lollipop3 };

            Console.WriteLine("Gift contents:");
            foreach (Sweet sweet in gift)
            {
                sweet.Display();
            }

            double totalWeight = gift.CalculateTotalWeight();
            Console.WriteLine($"Total weight of the gift: {totalWeight}g");

            gift.SortByName();

            Console.WriteLine("\nGift contents after sorting by name:");
            foreach (Sweet sweet in gift)
            {
                sweet.Display();
            }

            string flavorToSearch = "Shrek";
            Sweet foundCandy = gift.FindByFlavor(flavorToSearch);
            if (foundCandy != null)
            {
                Console.WriteLine($"\nFound a candy with flavor '{flavorToSearch}':");
                foundCandy.Display();
            }
            else
            {
                Console.WriteLine($"\nNo candy found with flavor '{flavorToSearch}'.");
            }
        }
    }
}