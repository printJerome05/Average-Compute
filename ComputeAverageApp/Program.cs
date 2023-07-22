using System;

namespace ComputeAverageApp
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Console.WriteLine("Enter 5 grades seperated by new line:  ");
       
             double g1 = Convert.ToDouble(Console.ReadLine());


            double g2 = Convert.ToDouble(Console.ReadLine());


            double g3 = Convert.ToDouble(Console.ReadLine());



            double g4 = Convert.ToDouble(Console.ReadLine());


            double g5 = Convert.ToDouble(Console.ReadLine());

            double average = (g1 + g2 + g3 + g4 + g5) / 5;



        


            Console.WriteLine("The average is " + average + " and round off to "+ Math.Round(average)) ;

        }
    }
}
