using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        Random random = new Random();
      
        Phone[] phones = new Phone[10];
            for(int i = 0; i < phones.Length; i++)

            {
                phones[i] = new Phone();    

                string[] models = { "Apple", "POCO", "SAMSUNG", "SONY" };
                bool[] vs = { true, false };
                string[] memory = { "64 Гб", "128 Гб", "256 Гб", "512 Гб" };

                int index = random.Next(models.Length);
                int index2 = random.Next(vs.Length);
                int index3 = random.Next(memory.Length);

                phones[i].Model = models[index];
                phones[i].Old = vs[index2];
                phones[i].Memory = memory[index3];

            }
            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i]);
               
            }

            Console.ReadLine();









        }

        
        
    }

}
