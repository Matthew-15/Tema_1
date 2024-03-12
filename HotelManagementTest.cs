namespace HotelManagement
{
    class HotelManagementTest
    {
        static void Main(string[] args)
        {
            DeluxeRoom room1 = new DeluxeRoom(101, 200, true);
            room1.BookRoom();
            room1.DisplayRoomInfo();
            room1.VacateRoom();
            room1.BookRoom();
        }
    }
}