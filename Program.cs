using System;

namespace Code1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Do you want hawaiian pizza?");
                var userResponse = Console.ReadLine();

            if (userResponse == "Yes")
            {
                Pizza.makeHawaiian();

            }
            else { Console.WriteLine("The pizza you have ordered is a " + Pizza.PizzaType + " Pizza"); }


        }








        class Pizza
        {
            public static string PizzaType = "Cheese";

            public static void makeHawaiian()
            {
                PizzaType = "Hawaiian";
                Console.WriteLine("The pizza you have ordered is a " + PizzaType + " Pizza");
            }

                
                }
            }
        }
    


