using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventurePage.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
