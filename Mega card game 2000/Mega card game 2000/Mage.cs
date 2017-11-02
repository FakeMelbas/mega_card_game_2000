using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_card_game_2000
{
    class Mage : PlayerCharacterType
    {
        //private int damage;
        public int damage;

        public void AttackSpecial(NonPlayerCharacter pTarget)
        {
            pTarget.health = pTarget.health - damage;
        }
        public Mage(int damage)
        {
            this.damage = damage;
        }
    }
}
