using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLearn.Models
{
    class Hotel
    {
        //add field for read class ReservationBook
        private readonly ReservationBook _reservationBook;
        //Init field Name for Hotel
        public string Name { get; }
        public Hotel(string name)
        {
            //init the reservationBook for this Hotel
            _reservationBook = new ReservationBook();
            Name = name;    
        }

        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservationBook.GetAllReservations(username);
        }

        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
