using System;
using System.Collections.Generic;
using System.Text;
using pesudoStructure.View;
using pesudoStructure.Model;

/*
 * NOTE TO SELF
 *  Make combat and non combat rooms... DONE
 *  Maybe Try a Binary Search Tree for rooms?
 */


namespace pesudoStructure.Controller
{
    class RoomGen
    {
        private const short REGIONSIZE = 3;
        Random rnd = new Random();
        // Basic Dictionary. Holds unique key with data values to it. Each key has a list linked to it of rooms.
        private Dictionary<Int16, List<Room<Monsters>>> listOfRooms = new Dictionary<short, List<Room<Monsters>>>();
        private Display view = new Display();

        // Generates the rooms at random. This uses lists to dynamically hold the nodes of rooms
        // The does for loops to seperate the regions from the rooms
        private void Generation()
        {
            // Region loop
            for(short i = 0; i < REGIONSIZE; i++)
            {
                // Rooms in Region. Dumbass. Learn Data Structures nerd
                List<Room<Monsters>> tempList = new List<Room<Monsters>>();
                int numRoom = rnd.Next(7, 17);
                int safeRoom = rnd.Next(4, numRoom);
                for(int r = 0; r < numRoom; r++)
                {
                    Room<Monsters> tempRoom = new Room<Monsters>();
                    if(r == (numRoom - 1)) { tempRoom.FinalMonster = AddingFinal(i); }
                    if(r != 0 && r != (numRoom - 1) && r != safeRoom)
                    {
                        int ranNum = rnd.Next(1, 5);
                        AddingMonster(tempRoom, i, ranNum);
                    }
                    tempList.Add(tempRoom);

                }
                listOfRooms.Add(i, tempList);
            }
        }

        // Breaking up the functions to add the monsters
        // Uses a switch case to case a random number bounded to a
        // set range to add the monsters to a list in the Room class
        private void AddingMonster(Room<Monsters> tempRoom, short regionIndex, int ranNum)
        {
            switch(regionIndex)
            {
                case 0:
                    for(int i = 0; i < ranNum; i++)
                    {
                        tempRoom.MonsterAdd((Monsters)rnd.Next(101,105));
                    } break;
                case 1:
                    for (int i = 0; i < ranNum; i++)
                    {
                        tempRoom.MonsterAdd((Monsters)rnd.Next(201, 205));
                    } break;

                case 2:
                    for (int i = 0; i < ranNum; i++)
                    {
                        tempRoom.MonsterAdd((Monsters)rnd.Next(301, 305));
                    } break;
            }
        }

        // Short hand for a function call to be simply a switch case
        // Creating the bosses for the Final Rooms
        private Monsters AddingFinal(int regionIndex) => regionIndex switch
        {
            0 => (Monsters)105,
            1 => (Monsters)205,
            2 => (Monsters)305,
            _ => default,
        };

        // The run function that links the dictionary structure to the display function
        // Fuck Matthan. He is too much of a project manager.....
        public void Run()
        {
            Generation();
            view.DisplayRooms(listOfRooms);
        }
    }
}
