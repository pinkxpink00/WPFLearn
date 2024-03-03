using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLearn.Models
{
    public class ReservationBook
    {
        private readonly Dictionary<RoomID, List<Reservation>> _roomReservations;
        //Init Dictionary RoomID and Reservation List
        public ReservationBook()
        {
            _roomReservations = new Dictionary<RoomID, List<Reservation>>();
        }
    }
}
