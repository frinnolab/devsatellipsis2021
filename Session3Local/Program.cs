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

              var johnBal  = 150.0;

           for (int i = 0 , j=0; i < menus.Length && j<prices.Length; i++,j++)
           {
               Console.WriteLine("Food : " + menus[i] + "    Price : " + prices[j]);

           }

                
           for (int i = 0; i <prices.Length; i++)
             {
                if (prices[i]<=johnBal)
             {
               Console.WriteLine("John Can afford " + menus[i]);
            }else
           {
              Console.WriteLine("John can't afford " + menus[i]);
            }
}  

                
           }
 

        }
    }

