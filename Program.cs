using Microsoft.Extensions.DependencyInjection;

namespace Module2_Ex4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddTransient<IVegetable, Tomato>()
            .AddTransient<IVegetable, Cucumber>()
            .AddTransient<IVegetable, Lettuce>()
            .BuildServiceProvider();

            var tomato = serviceProvider.GetService<IVegetable>();
            tomato.Weight = 200;

            var cucumber = serviceProvider.GetService<IVegetable>();
            cucumber.Weight = 150;

            var lettuce = serviceProvider.GetService<IVegetable>();
            lettuce.Weight = 100;

            var salad = new Salad(new IVegetable[] { tomato, cucumber, lettuce });

            Console.WriteLine($"Total calories: {salad.CalculateTotalCalories()}");

            var veggies = salad.FindByCalories(20, 30);
            foreach (var veggie in veggies)
            {
                Console.WriteLine($"Found: {veggie.Name} with total calories: {veggie.CalculateTotalCalories()}");
            }

            salad.SortByCalories();
            foreach (var veggie in salad.Vegetables)
            {
                Console.WriteLine($"{veggie.Name} with total calories: {veggie.CalculateTotalCalories()}");
            }
        }
    }
}