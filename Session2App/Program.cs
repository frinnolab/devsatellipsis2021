using System;

namespace Session2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DOPE session 2!");
            Console.WriteLine("Enter  username");
            string username =  Console.Readline();
            Console.WriteLine("username is:" + username);

            console.WriteLine("Enter your age");
            int  age = convert.ToInt32(console.Readline());
            console.WriteLine("Your  age is:"+ age);
            console.WriteLine("Account with  username:"+username,"age:"+age,"successfully  created");
        }
    }
}
