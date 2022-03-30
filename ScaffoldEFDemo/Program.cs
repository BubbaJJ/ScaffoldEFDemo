using ScaffoldEFDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScaffoldEFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa koppling till databasen
            using var db = new demoday3Context();
            try
            {
                db.UniqueCrashes.Add(new UniqueCrash { Name = "Johan" });

                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //// Hämta alla användare
            //var allUsers = db.Users.ToList();

            //foreach (var item in allUsers)
            //{
            //    Console.WriteLine(item.FirstName);
            //}

            //// Hämta en specifik användare
            //var currentUser = db.Users.Single(x => x.Id == 1);
            //Console.WriteLine(currentUser.FirstName);

            //// Ändra användarens namn
            //currentUser.FirstName = "Johan";

            //// Spara ändringar till databasen
            //db.SaveChanges();

            //// Hämta alla användare som matchar ett villkor
            //List<User> selectedUsers = db.Users.Where(x => x.Id > 2).ToList();

            //// Lägg till en användare
            //db.Users.Add(new User { FirstName = "Robin", LastName = "Kamo", AddressId = 2 });

            //// Spara ändringar till databasen
            //db.SaveChanges();
        }
    }
}