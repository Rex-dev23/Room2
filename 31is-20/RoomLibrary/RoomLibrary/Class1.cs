using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLength;
        double roomWidth;

        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }

        }

        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }

        public double RoomPerimeter()
        {
            return 2 * (roomLength + roomWidth);
        }

        public double RoomArea()
        {
            return roomLength + roomWidth;
        }

        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
    }

    public class LivingRoom : Room
    {
        int numWin; 
           public int NumWin
        { get { return numWin; } set { numWin = value; } }

        public string Info()
        {
            return "Жилая комната площадью" + RoomArea() + "кв.м, с" + "окнами";
        }
        public double PersonArea (int np)
        {
            return RoomArea() / np;
        }

    }
}
