using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOPDemo.Logic;

namespace AOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username: ");
            var userName = Console.ReadLine();
            Console.Write("FullName: ");
            var fullName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("##### Output Start #####");

            try
            {
                var userManager = new UserManager();
                userManager.AddUser(userName, fullName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine("###### Output End ######");

        }
    }
}
