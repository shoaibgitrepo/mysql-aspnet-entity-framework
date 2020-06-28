using ConsoleApp1.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SdDbContext();

            var users = context.Users.ToList();

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }
    }
}
