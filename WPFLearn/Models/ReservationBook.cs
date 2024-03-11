using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFLearn.Exceptions;

namespace WPFLearn.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;
        //Init Reservations
        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }
        //Init View for User
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservations;
        }
        //Init for making reservation for user
        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservation in _reservations)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }
            _reservations.Add(reservation);
        }

    }
}
