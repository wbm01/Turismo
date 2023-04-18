﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndreTurismo.Models;
using AndreTurismo.Services;

namespace AndreTurismo.Controllers
{
    public class HotelController
    {
        public bool InsertHotel(Hotel hotel)
        {
            hotel.AddressHotel = new AddressService().InsertAddress(hotel.AddressHotel);
            return new HotelService().InsertHotel(hotel);
        }

        public bool DeleteHotel(Hotel hotel)
        {
            return new HotelController().DeleteHotel(hotel);
        }

        public List<Hotel> GetHotelList()
        {
            return new HotelController().GetHotelList();
        }

        public bool UpdateHotel(Hotel hotel)
        {
            return new HotelController().UpdateHotel(hotel);
        }
    }
}
