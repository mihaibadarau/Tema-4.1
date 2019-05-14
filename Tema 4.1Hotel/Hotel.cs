using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4._1Hotel
{
    public class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<Room> Rooms { get; set; }

        public void  Print()
        {
            Console.WriteLine($"{Name},{City}");
        }

        public void PrintRooms()
        {
            foreach (var room in Rooms)
            {
                Console.WriteLine($"{room.Name}, {room.Rate}");
            }
        }
    }
}
