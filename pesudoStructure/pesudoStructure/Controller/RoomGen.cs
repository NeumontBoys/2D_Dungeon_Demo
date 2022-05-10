using System;
using System.Collections.Generic;
using System.Text;
using pesudoStructure.View;
using pesudoStructure.Model;

namespace pesudoStructure.Controller
{
    class RoomGen
    {
        private const short REGIONSIZE = 3;
        Random rnd = new Random();
        private Dictionary<Int16, List<Room<Monsters>>> listOfRooms = new Dictionary<short, List<Room<Monsters>>>();
        private Display view = new Display();

        private void Generation()
        {
            for(short i = 0; i < REGIONSIZE; i++)
            {
                List<Room<Monsters>> tempList = new List<Room<Monsters>>();
                int numRoom = rnd.Next(2, 6);
                for(int r = 0; r < numRoom; r++)
                {
                    Room<Monsters> tempRoom = new Room<Monsters>();
                    AddingMonster(tempRoom, i);
                    if(r == (numRoom - 1)) { tempRoom.FinalMonster = true; }
                    tempList.Add(tempRoom);
                }
                listOfRooms.Add(i, tempList);
            }
        }

        private void AddingMonster(Room<Monsters> tempRoom, short regionIndex)
        {
            int ranNum = rnd.Next(1, 5);
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

        //private void AddingMon()

        public void Run()
        {
            Generation();
            view.DisplayRooms(listOfRooms);
        }
    }
}
