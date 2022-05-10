using System;
using System.Collections.Generic;
using System.Text;
using pesudoStructure.Controller;
using pesudoStructure.Model;

namespace pesudoStructure.View
{
    class Display
    {
        public void DisplayRooms(Dictionary<short, List<Room<Monsters>>> listRooms)
        {
            foreach(KeyValuePair<short, List<Room<Monsters>>> elm in listRooms)
            {
                int counter = 1;
                foreach(Room<Monsters> room in elm.Value)
                {
                    Console.WriteLine("\nRegion: {0}, Room: {1}, Boss: {2}", elm.Key, counter, room.FinalMonster);
                    counter++;
                    foreach(Monsters mon in room.Monster)
                    {
                        Console.Write("{0}, ", mon);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
