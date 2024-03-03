using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLearn.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public Reservation(RoomID roomID,DateTime startTime,DateTime endTime)
        {
            //Init data about reservation
            RoomID = roomID;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
