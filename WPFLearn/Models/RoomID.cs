using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLearn.Models
{
    public class RoomID
    {
        public RoomID(int floorNumber, int roomNubmer)
        {
            FloorNumber = floorNumber;
            RoomNubmer = roomNubmer;
        }

        public override string ToString()
        {
            return $"{FloorNumber}{RoomNubmer}";
        }

        public int FloorNumber { get; }
        public int RoomNubmer { get; }

        public override bool Equals(object? obj)
        {
            return obj is RoomID roomId &&
                FloorNumber == roomId.FloorNumber &&
                RoomNubmer == roomId.RoomNubmer;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNubmer);
        }
    }
}
