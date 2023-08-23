namespace Mod2_Ex6
{
    class Run
    {
        static void Main(string[] args)
        {
            ElectricalAppliance[] appliances = new ElectricalAppliance[]
        {
            new KitchenAppliance("Fridge", 150, "Samsung"),
            new EntertainmentAppliance("TV", 120, 50),
            new KitchenAppliance("Microwave", 1000, "Panasonic"),
        };

            appliances[0].PlugIn();
            appliances[2].PlugIn();

            IApplianceOperations operations = new ApplianceOperations();
            Console.WriteLine("Total Power Consumption: " + operations.CalculateTotalPowerConsumption(appliances) + "W");

            Console.WriteLine("\nAppliances sorted by power:");
            operations.SortAppliancesByPower(appliances);
            foreach (var appliance in appliances)
            {
                Console.WriteLine(appliance);
            }

            Console.WriteLine("\nAppliances in the power range 100W to 500W:");
            var foundAppliances = appliances.FindByPowerRange(100, 500);
            foreach (var appliance in foundAppliances)
            {
                Console.WriteLine(appliance);
            }
        }
    }
}