using System;

namespace Classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars();
            car.Brand = "";
            car.Model = "";
            car.Price = 2600;
            car.Year=2020;


            Cars car2 = new Cars();
            car2.Brand = "ada";

            var masin = new
            {
                brand = "mercedes",
                year = 2022,
                price= 2400

            };

            var huseyn = new 
            {
               agil= "low level",
               xasiyyet="neblimala",
               dozumluluk= "high"

            };

            var car1 = new 
            {
                brand="Bmw",
                Year="2020"
            
            };



        }
        static double Average(Cars[] carsArray)
        {
          
            double sum = 0;
            
            for(int i=0; i<carsArray.Length; i++)
            {
                sum +=carsArray[i].Price;
               

            }
            return sum / carsArray.Length;


        }
    }
}
