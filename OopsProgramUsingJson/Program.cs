using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgramUsingJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "D:\\Users\\LENOVO\\Desktop\\navitha\\InventaoryDataMangement\\InventoryData.json";
            FetchForJsonRiceData fetchForJsonRiceData = new FetchForJsonRiceData();



            Rice data = fetchForJsonRiceData.Read(filepath);

            // Console.WriteLine(data.typeOfRice.name);
            //Console.WriteLine(data.typeOfRice.weight);
            //Console.WriteLine(data.typeOfRice.price);


            Console.WriteLine("Data for Rice");
            for (int i = 0; i < data.typeOfRice.Count; i++)
            {
                Console.WriteLine(data.typeOfRice[i].name);
                Console.WriteLine(data.typeOfRice[i].weight);
                Console.WriteLine(data.typeOfRice[i].price);
                int value = data.typeOfRice[i].weight * data.typeOfRice[i].price;
                Console.WriteLine(value);
                Console.WriteLine("_________________________________");

            }


            Console.WriteLine("Data for pluse");
            for (int i = 0; i < data.TypeOfPluse.Count; i++)
            {
                Console.WriteLine(data.TypeOfPluse[i].name);
                Console.WriteLine(data.TypeOfPluse[i].weight);
                Console.WriteLine(data.TypeOfPluse[i].price);
                int value = data.TypeOfPluse[i].weight * data.TypeOfPluse[i].price;
                Console.WriteLine(value);
                Console.WriteLine("_________________________________");

            }

            Console.WriteLine("Data for wheat");
            for (int i = 0; i < data.TypeOfWheat.Count; i++)
            {
                Console.WriteLine(data.TypeOfWheat[i].name);
                Console.WriteLine(data.TypeOfWheat[i].weight);
                Console.WriteLine(data.TypeOfWheat[i].price);
                int value = data.TypeOfWheat[i].weight * data.TypeOfWheat[i].price;
                Console.WriteLine(value);
                Console.WriteLine("_________________________________");


            }

            Console.ReadLine();







        }
    }
}

