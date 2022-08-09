using Lessons.Entities;
using Lessons.Entities.Exceptions;
using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-In data (dd/mm/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-Out data (dd/mm/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine("Update the reservation: ");
                Console.Write("Check-In data (dd/mm/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-Out data (dd/mm/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());


                reservation.UpdateDate(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in Reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Erro: " + e.Message);
            }
        }
    }
}
