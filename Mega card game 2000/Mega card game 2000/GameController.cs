using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_card_game_2000
{
    class GameController
    {
        //private Character enemy;
        public Character enemy;
        //private PlayerCharacter player;
        public PlayerCharacter player;

        public GameController()
        {
            enemy = new Character();
            player = new PlayerCharacter();
        }
    }
}
