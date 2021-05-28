using System;

namespace sess5Local
{
    class Program
    {
        static long earth_time=31557600L;
        static long traveler_time=631154000L;
        static float traveler_Ages;
        static float earth_in_space_age;
      
        static void Main(string[] args)
        {
        
        Program.earthAge(earth_time,traveler_time);
        Program.printArrayOfAge(earth_in_space_age);
        
        }

        public static float earthAge(long earth_time,long traveler_time)
        {
             earth_in_space_age = traveler_time/earth_time;
             Console.WriteLine("Earth age is " + traveler_time/earth_time + "Earth years old");
             return earth_in_space_age; 

        }


        public static float printArrayOfAge(float ages)
        {
            
            String [] planets = new string[4];
            planets[0]="Venus";
            planets[1]="Mars";
            planets[2]="Jupiter";
            planets[3]="Neptune";
            
            float [] age = new float[4];
            age[0]=0.61519726F;
            age[1]=1.8808158F;
            age[2]=11.862615F;
            age[3]=164.79132F;


        for (int j=0; j< age.Length; j++)
        {
        traveler_Ages = earth_in_space_age/age[j];
        Console.WriteLine(planets[j] + " age is : " + traveler_Ages + " Earth-years old ");
        }
         return traveler_Ages;
        }
    }
}
