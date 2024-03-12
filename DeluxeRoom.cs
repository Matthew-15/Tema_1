using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelManagement
{
    public class DeluxeRoom : Room  // Inheritance: clasa DeluxeRoom moștenește clasa Room
    {
        private bool hasMiniBar;

        public DeluxeRoom(int roomNumber, double price, bool hasMiniBar) : base(roomNumber, price)
        {
            this.hasMiniBar = hasMiniBar;
        }

        public void DisplayRoomInfo() 
        {
            Console.WriteLine($"Room Number: {GetRoomNumber()}");  // Encapsulation: folosirea metodelor publice pentru a accesa datele private
            Console.WriteLine($"Price: {GetPrice()}");
            Console.WriteLine($"Occupied: {IsOccupied()}");
            Console.WriteLine($"Mini Bar Available: {hasMiniBar}");
        }
    }
}
