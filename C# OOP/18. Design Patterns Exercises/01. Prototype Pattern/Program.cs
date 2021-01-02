using System;
using System.Text.Json;

namespace _01._Prototype_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Sandwich mySandwich = new Sandwich("Wheat", "Bacon", "Lettuce", "Tomatoes");
            Ingridient myIngridient = new Ingridient("Ingridient Name", 10);
            mySandwich.Ingridient = myIngridient;

            JsonSerializerOptions opts = new JsonSerializerOptions { WriteIndented = true };

            string JsonSandwich = JsonSerializer.Serialize(mySandwich, opts);

            Sandwich sandwichCopy = JsonSerializer.Deserialize<Sandwich>(JsonSandwich);

            Console.WriteLine(sandwichCopy);

        }
    }
}
