using System;

namespace sess4Local
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            
            long earth_time=31557600L;
            long traveler_time=631154000L;


            String [] planets = new string[4];
            planets[0]="Venus";
            planets[1]="Mars";
            planets[2]="Jupiter";
            planets[3]="Neptune";

            long [] age = new long[4];
            age[0]=19414149L;
            age[1]=59354032L;
            age[2]=374355659L;
            age[3]=5200418560L;

    float earth_in_space_age = traveler_time/earth_time;

    for (int i = 0 , j=0; i < planets.Length && j< age.Length; i++,j++)
    {
    float traveler_years = earth_in_space_age/age[j];
    Console.WriteLine(planets[i] + " age is : " + traveler_years + " Earth-years old ");
     }
    }
 }
}
