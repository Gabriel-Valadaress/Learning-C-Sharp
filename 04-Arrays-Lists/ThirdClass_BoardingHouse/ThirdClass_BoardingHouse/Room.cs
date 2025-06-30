using System;

namespace ThirdClass_BoardingHouse
{
    class Room
    {
        public int RoomNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{RoomNumber}: {Name}, {Email}";
        }
    }
}
