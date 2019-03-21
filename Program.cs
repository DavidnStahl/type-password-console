using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace askforpassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Password: ");
            string passwordUser = Console.ReadLine();
            string passwordCorrect = "dog3411";
            if (passwordUser == passwordCorrect)
            {
                Console.WriteLine("Welcome to the system");
            }
            else
            {
                Console.WriteLine("Wrong password! Go home ...\"..");
            }
            Console.ReadLine();


            //If it is the correct password, it should be displayed "Welcome to the system".
            //If there is a wrong password, it should show "Wrong password! Go home ..."..
        }
    }
}
