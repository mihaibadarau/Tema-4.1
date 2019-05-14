using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4._1Hotel
{
    public class HotelManager
    {
        public string Name { get; set; }
        public List<Hotel> Hotels { get; set; }

        public void AddHotel(Hotel hotelDeAdaugat)
        {
           Hotels.Add(hotelDeAdaugat);
        }

        public void DeleteHotel(int position)
        {
            Hotels.RemoveAt(position);
        }
    }
}
