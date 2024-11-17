using LangConsoleApp.Storehouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangConsoleApp
{
    internal class Program20
    {
        public static void Run()
        {
            Console.WriteLine("C# - Indexers");
            Console.WriteLine("An indexer is a special type of property that allows a class or a structure to be accessed like an array for its internal collection.");
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-indexer");
            Console.WriteLine("----------------------------------------");

            GreetingStore greetingStore = new GreetingStore();
            Console.WriteLine("GreetingStore:");
            for (int i = 0; i < greetingStore.GetStoreSize(); i++)
            {
                Console.WriteLine($"[{i}] = {greetingStore[i]}");
            }
            Console.WriteLine("----------------------------------------");

            NumberPlateStore numberPlateStore = new NumberPlateStore();
            string numberPlateAs01 = numberPlateStore[1];
            int numberPlateAsThree = numberPlateStore["Three"];
            int numberPlateAsXyztw = numberPlateStore["Xyztw"];
            Console.WriteLine("NumberPlateStore:");
            Console.WriteLine($"NumberPlateStore: index = 1     => {numberPlateAs01}");
            Console.WriteLine($"NumberPlateStore: index = Three => {numberPlateAsThree}");
            Console.WriteLine($"NumberPlateStore: index = Xyztw => {numberPlateAsXyztw}");
            Console.WriteLine("----------------------------------------");

            GenericDataStore<int> intStore = new GenericDataStore<int>();
            for (int i = 0; i < intStore.GetStoreSize(); i++)
            {
                intStore[i] = i + 10;
            }
            Console.WriteLine("IntDataStore:");
            for (int i = 0; i < intStore.GetStoreSize(); i++)
            {
                Console.WriteLine($"IntDataStore: index = {i} => {intStore[i]}");
            }
        }
    }
}
