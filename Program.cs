

using Hospedagem_project.Models;

// Create a guest list.
List<Person> guests = new List<Person>();

// Introduce/create the peoples.
Person personOne = new Person(name: "Lucas");
personOne.LastName = "Mattos";
Person personTwo = new Person(name: "Marian");
personTwo.LastName = "Chagas";

// Add the peoples to a guests list.
guests.Add(personOne);
guests.Add(personTwo);

// Create a suites.
Suite suiteOne = new Suite(suiteType: "Premium", capacity: 2, diaryValue: 30.00M);
Suite suiteTwo = new Suite(suiteType: "Normal", capacity: 4, diaryValue: 20.00M);

// A default reserv, just for get all guests.
Reservation reservation = new Reservation();
reservation.RegisterGuest(guests);

// Create the reservs for each person.
Reservation reservationOne = new Reservation(reservedDays: 20);
Reservation reservationTwo = new Reservation(reservedDays: 10);

reservationOne.RegisterSuite(suiteOne);
Console.WriteLine($"Value to pay: {reservationOne.CalculateDairyValue()}");

reservationTwo.RegisterSuite(suiteTwo);
Console.WriteLine($"Value to pay: {reservationTwo.CalculateDairyValue()}");

// Return all guests registered.
Console.WriteLine($"Total of guest registered --> {reservation.GetGuestQuantity()}");