using System;

namespace Session3App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Session 3 App");

            //Initialization
            #region Arrays
            
            //DataType [] name = new DataType [length]
            int [] ages = new int [4];
            ages[0] = 67;
            ages[1] = 15;
            ages[2] = 31;
            ages[3] = 78;
            
            //String Arrays
            string [] locations = new string[3];
            locations[0] = "Dar es salaam";
            locations[1] = "Nairobi";
            locations[2] = "Joburg";

            //Double arrays
            double[] balance = new double[3]{100.4, 253.4, 17.64};

            string oddCity = locations[2];
            #endregion

            #region Conditionals
            
            //Conditionals
            //If/ Else
            if(balance[0]!=100.4){
                balance[0] = 100.5;
            }else{
                Console.WriteLine("Balance: "+ balance[0]);
            }


            //Switch
            switch(locations[0]){
                case "Dar es salaam":
                    Console.WriteLine("location: "+ locations[0]);
                    break;
                case "Nairobi":
                    Console.WriteLine("location: "+ locations[0]);
                    break;
                default :
                    Console.WriteLine("Location doesn't exist");
                    break;
            }
            #endregion
           // Console.WriteLine(balance[0]);
        }
    }
}
