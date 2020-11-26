using System;

namespace Lorem.NetCore.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Email: {LoremNETCore.Generate.Email()}");
            Console.WriteLine($"Chance: {LoremNETCore.Generate.Chance(1, 2)}");
            Console.WriteLine($"Words: {LoremNETCore.Generate.Words(5)}");

            Console.WriteLine();
            Console.WriteLine("Change the source...");
            LoremNETCore.Source.Update("Alright stop collaborate and listen ice is back with my brand new invention something grabs a hold of me tightly flow like a harpoon daily and nightly will it ever stop yo I don't know turn off the lights and I'll glow");

            Console.WriteLine($"Sentence: {LoremNETCore.Generate.Sentence(5, 25)}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
