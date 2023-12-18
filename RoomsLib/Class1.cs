using System;
using System.Collections.Generic;

namespace RoomsLib
{
    public static class RoomList
    {
        public static List<int> GenerateRoomNumbers()
        {
            List<int> rooms = new List<int>();

            // generate a list of rooms from 1500-4950
            for (int i = 1500; i < 4951; i++)
            {
                rooms.Add(i);
            }

            return rooms;
        }
    }
}
