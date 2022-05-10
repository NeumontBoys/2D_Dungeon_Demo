using System;
using System.Collections.Generic;
using System.Text;
using pesudoStructure.View;

namespace pesudoStructure.Controller
{
    class RoomGen
    {
        const int REGIONSIZE = 3;
        Random rnd = new Random();
        Dictionary<Int16, List<Room<Int32>>> listOfRooms = new Dictionary<short, List<Room<Int32>>>();
        Display view = new Display();

        private void Generation()
        {
            for(short i = 0; i < REGIONSIZE; i++)
            {
                List<Room<Int32>> tempList = new List<Room<Int32>>();
                int numRoom = rnd.Next(6);
                for(int r = 0; r < numRoom; r++)
                {
                    Room<Int32> tempRoom = new Room<Int32>();
                    tempRoom.MonsterAdd(rnd.Next(54));
                    if(r == (numRoom - 1)) { tempRoom.FinalMonster = true; }
                    tempList.Add(tempRoom);
                }
                listOfRooms.Add(i, tempList);
            }
        }

        public void Run()
        {
            Generation();
            view.DisplayRooms(listOfRooms);
        }






        
    }
}
