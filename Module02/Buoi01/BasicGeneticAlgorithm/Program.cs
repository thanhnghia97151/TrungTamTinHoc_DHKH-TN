using System;

namespace BasicGeneticAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual individual = new Individual(10);
            Console.WriteLine(individual);

            individual.SetGene(3, 1);
            Console.WriteLine(individual.GetGene(4));

            //Gần giồn Array
            individual[5] =1;
            Console.WriteLine(individual[7]);
        }
    }
}
