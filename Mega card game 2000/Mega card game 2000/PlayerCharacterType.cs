using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_card_game_2000
{
    public class PlayerCharacterType
    {
        //private int damage;
        public int damage;
        Random random;

        public void AttackSpecial(NonPlayerCharacter pTarget)
        {
            pTarget.health = pTarget.health - damage;
        }
    }

}
