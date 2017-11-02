using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_card_game_2000
{
    public class Warrior : PlayerCharacterType
    {   
        //private int damage;
        public int damage;

        public void AttackSpecial(NonPlayerCharacter pTarget)
        {
            pTarget.health = pTarget.health - damage;
        }
        public Warrior(int damage)
        {
            this.damage = damage;
        }

    }
}
