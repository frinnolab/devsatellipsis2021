using System;

namespace Session2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your UserName :");
String user_name=Console.ReadLine();
Console.WriteLine("Enter your Age :");
int age=System.Convert.ToInt32(Console.ReadLine());
Console.WriteLine("age is " + age);
Console.WriteLine("Account with UserName : " + user_name + " and Age " + age + " is successfully created!");
        }
    }
}
