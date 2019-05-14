using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4._1Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name for the new hotel");
            var hotelName = Console.ReadLine();

            Console.WriteLine("Enter the city for the new hotel");
            var hotelCity = Console.ReadLine();

            var room1 = new Room();
            room1.Name = "Camera1";
            room1.Rate = 100;

            var room2 = new Room();
            room2.Rate = 200;
            room2.Name = "Camera2";

            var room3 = new Room();
            room3.Rate = 75;
            room3.Name = "Camera3";

            var room4 = new Room();
            room4.Rate = 110;
            room4.Name = "Camera4";

            var room5 = new Room();
            room5.Rate = 165;
            room5.Name = "Camera5";

            var room6 = new Room();
            room6.Rate = 195;
            room6.Name = "Camera6";

            var listaCamere1 = new List<Room>();
            listaCamere1.Add(room1);
            listaCamere1.Add(room2);
            listaCamere1.Add(room3);

            var listaCamere2 = new List<Room>();
            listaCamere2.Add(room4);
            listaCamere2.Add(room5);
            listaCamere2.Add(room6);

            var hotel1 = new Hotel();
            hotel1.City = "iasi";
            hotel1.Name = "Traian";
            hotel1.Rooms = listaCamere1;

            var hotel2 = new Hotel();
            hotel2.City = "Iasi";
            hotel2.Name = "Astoria";
            hotel2.Rooms = listaCamere2;

            hotel1.Print();
            hotel1.PrintRooms();

            hotel2.Print();
            hotel2.PrintRooms();

            var hotelManagerList = new List<Hotel>();

            var hotelManager = new HotelManager();
            hotelManager.Name = "Smecher";
            hotelManager.Hotels = hotelManagerList;

            hotelManager.AddHotel(hotel1);
            hotelManager.AddHotel(hotel2);

            hotelManager.AddHotel(new Hotel { City = hotelCity, Name = hotelName, Rooms = new List<Room>()});

            //hotelManager.DeleteHotel(0);

            foreach (var hotel in hotelManager.Hotels)
            {
                Console.WriteLine($"Aceste este hotelul din hotel manager {hotel.Name}, {hotel.City}");
            }

            var listOfRates = new List<int>();

            foreach (var hotel in hotelManager.Hotels)
            {
                foreach (var room in hotel.Rooms)
                {
                    listOfRates.Add(room.Rate);
                }
            }

            var cheapRoom = listOfRates.Min();

            Console.WriteLine(cheapRoom);
        }
    }
}
