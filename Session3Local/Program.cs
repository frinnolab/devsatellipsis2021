using System;

namespace Session3Local
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");


           String [] menus = new String[4];
           menus[0] ="Robster Miano";
           menus[1] ="Smashed Potato Salad";
           menus[2] ="Vegan Sushi";
           menus[3] = "Grilled Salmon";

           float [] prices = new float[4];
           prices[0] =256.4f;
           prices[1] =102.1f;
           prices[2] =152.8f;
           prices[3]=93.9f;

           for (int i = 0 , j=0; i < menus.Length && j<prices.Length; i++,j++)
           {
               Console.WriteLine("Food : " + menus[i] + "    Price : " + prices[j]);

                 if(prices[j]<=150.00) {

                Console.WriteLine("John can afford the food");
                } 
                 else{
                    Console.WriteLine("John can not afford the food");
                }  

                
           }
 

        }
    }
}
