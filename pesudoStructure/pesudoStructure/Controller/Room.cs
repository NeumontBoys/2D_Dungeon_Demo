using System;
using System.Collections.Generic;
using System.Text;

namespace pesudoStructure.Controller
{
    class Room<T>
    {
        // Room Data Object. This holds a list of Generic Types.
        // Meaning we can add what ever we want it there when
        // creating the object (Used of testing).
        // Setters and getters for the lists and fields..
        private List<T> monsters = new List<T>();
        private T finalMonster;
        
        public List<T> Monster { get { return monsters; } }

        public void MonsterAdd(T val) { monsters.Add(val); }

        public T FinalMonster
        {
            set { finalMonster = value; }
            get { return finalMonster; }
        }
    }
}
