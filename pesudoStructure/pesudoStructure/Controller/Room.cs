using System;
using System.Collections.Generic;
using System.Text;

namespace pesudoStructure.Controller
{
    class Room<T>
    {
        private List<T> monsters = new List<T>();
        private bool finalMonster = false;
        
        public List<T> Monster { get { return monsters; } }

        public void MonsterAdd(T val) { monsters.Add(val); }

        public bool FinalMonster
        {
            get { return finalMonster; }
            set { finalMonster = value; }
        }
    }
}
