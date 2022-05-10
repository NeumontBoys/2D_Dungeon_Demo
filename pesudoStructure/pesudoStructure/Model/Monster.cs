using System;
using System.Collections.Generic;
using System.Text;

namespace pesudoStructure.Model
{
    // Public Enum that has values associated to the keys. So you can Cast value to key or vise versa
        public enum Monsters
        {
            // Region 1
            Goblin = 101,
            Slime = 102,
            Wolf = 103,
            Snake = 104,

            // Region 2
            Hobgoblin = 201,
            Toxic_Slime = 202,
            Arch_Demon = 203,
            Dire_Wolf = 204,
            
            // Region 3
            Orge = 301,
            Toxic_Sludge = 302,
            Devil = 303,
            Medusa = 304
        }

        public enum FinalMonstors
        {
            Demon,              // 0
            Two_Headed_Serpent, // 1
            Cerberus            // 2
        }
    }
