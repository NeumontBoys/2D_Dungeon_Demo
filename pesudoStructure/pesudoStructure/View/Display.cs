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
            // Does a for each loop through all of the keys in the dictionary to be able to grab the lists 
            // You are welcome Dick Head Bitch
            foreach(KeyValuePair<short, List<Room<Monsters>>> elm in listRooms)
            {
                int counter = 1;
                // Loops through the room list from the dictionary to display each room
                foreach(Room<Monsters> room in elm.Value)
                {
                    Console.WriteLine("\nRegion: {0}, Room: {1}, Boss: {2}", elm.Key, counter, room.FinalMonster);
                    counter++;
                    // Loops through each monster list in the room
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
