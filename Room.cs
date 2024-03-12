using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelManagement
{
    public class Room
    {
        private int roomNumber; // Encapsulation: variabilele private pentru a proteja datele
        private double price;
        protected bool isOccupied;

        public Room(int roomNumber, double price)
        {
            this.roomNumber = roomNumber; // Encapsulation: folosirea de variabile private
            this.price = price;
            isOccupied = false;
        }

        public int GetRoomNumber()  // Encapsulation: metode publice pentru a accesa variabilele private
        {
            return roomNumber;
        }

        public double GetPrice()
        {
            return price;
        }

        public bool IsOccupied()
        {
            return isOccupied;
        }

        public void BookRoom()  // Encapsulation: metode publice pentru a accesa variabilele private
        {
            if (!isOccupied)
            {
                isOccupied = true;
                Console.WriteLine($"Room {roomNumber} has been booked.");
            }
            else
            {
                Console.WriteLine($"Room {roomNumber} is already occupied.");
            }
        }

        public void VacateRoom()  // Encapsulation: metode publice pentru a accesa variabilele private
        {
            if (isOccupied)
            {
                isOccupied = false;
                Console.WriteLine($"Room {roomNumber} has been vacated.");
            }
            else
            {
                Console.WriteLine($"Room {roomNumber} is already vacant.");
            }
        }
    }
}

