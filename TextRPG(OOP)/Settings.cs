using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_OOP_
{
    /// <summary>
    /// Holds the base values for all Characater
    /// </summary>
    internal class Settings
    {
        //Base values for all stats. 
        public int PlasmoidBaseHP { get; set; }
        public int PlasmoidBaseDamage { get; set; }
        public int ConstructBaseHP { get; set; }
        public int ConstructBaseDamage { get; set; }
        public int GoblinFolkBaseHP { get; set; }
        public int GoblinFolkBaseDamage { get; set; }
        public int playerMaxHP { get; set; }
        public int playerStartingCoins { get; set; }
        public int PlayerBaseDamager { get; set; }

        public Settings()
        {
            PlasmoidBaseHP = 3;
            PlasmoidBaseDamage = 0;
            ConstructBaseHP = 3;
            ConstructBaseDamage = 0;
            GoblinFolkBaseHP = 1;
            GoblinFolkBaseDamage = 0;
            playerMaxHP = 10;
            playerStartingCoins = 0;
            PlayerBaseDamager = 1;
        }
    }
}
