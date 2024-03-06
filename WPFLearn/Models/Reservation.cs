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
        public string UserName { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Lenght => EndTime.Subtract(StartTime);
        public Reservation(RoomID roomID,string userName,DateTime startTime,DateTime endTime)
        {
            //Init data about reservation
            RoomID = roomID;
            UserName = userName;
            StartTime = startTime;
            EndTime = endTime;
        }

        public bool Conflicts(Reservation reservation)
        {
            
        }
    }
}
