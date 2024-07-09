using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem_project.Models
{
    public class Reservation
    {
        // Default constructor.
        public Reservation(){}
        
        /// <summary>
        /// Constructor to made a suite reserv.
        /// </summary>
        /// <param name="reservedDays"> Reserved days to calculate the discount</param>
        public Reservation(int reservedDays) => ReservedDays = reservedDays;

        public List<Person> Guest { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public void RegisterGuest(List<Person> guest)
        {
            Guest = guest;
            foreach (var person in Guest)
            {
                Console.WriteLine($" {person.Name} has been register.");
            }
            Thread.Sleep(1000);
            Console.WriteLine("-----------------------");
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;

            Console.WriteLine($"Suite {Suite.SuiteType} has been register.");
            Console.WriteLine("-----------------------");

            Thread.Sleep(1500);
        }

        public int GetGuestQuantity() => Guest.Count;

        public decimal CalculateDairyValue()
        {
            decimal totalWithoutDiscount = Suite.DiaryValue * ReservedDays;
            decimal totalToPay;
            decimal discount;

            if (ReservedDays > 10)
            {
                Console.WriteLine("You got a discount of 10%.");
                Console.WriteLine("-----------------------");

                discount = totalWithoutDiscount * 10 / 100;
                totalToPay = totalWithoutDiscount - discount;

                return totalToPay;
            }
            else
            {
                totalToPay = Suite.DiaryValue * ReservedDays;
                return totalToPay;
            }
        }

    }
}