using System;
using System.Collections.Generic;
using System.Text;
using pesudoStructure.Controller;

namespace pesudoStructure.View
{
    class Display
    {
        public void DisplayRooms(Dictionary<short, List<Room<Int32>>> listRooms)
        {
            foreach(KeyValuePair<short, List<Room<Int32>>> elm in listRooms)
            {
                int counter = 1;
                foreach(Room<Int32> room in elm.Value)
                {
                    Console.WriteLine("Region: {0}, Room: {1}, Boss: {2}", elm.Key, counter, room.FinalMonster);
                    counter++;
                }
            }
        }
    }
}
