using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace ConsoleAppTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var UsersRepo = new UserRepository();
            var users = UsersRepo.GetUsers();
            Console.WriteLine("Ukupno: " + users.Count);
            foreach (var user in users)
            {
                Console.WriteLine(user.sName);
            }
            Console.ReadKey();
        }
    }
}
