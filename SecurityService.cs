using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo
{
    public enum Permission { AddUser }

    public class SecurityService
    {
        public void Authenticate()
        {
            Console.WriteLine("- Authenticate request");
        }

        public void Authorize(Permission permission)
        {
            Console.WriteLine("- Authorize request:" + permission.ToString());
        }
    }
}
