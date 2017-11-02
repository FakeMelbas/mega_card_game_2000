using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_card_game_2000
{
    public class Thief : PlayerCharacterType
    {
        //private int damage;
        public int damage;

        public void AttackSpecial(NonPlayerCharacter pTarget)
        {
            pTarget.health = pTarget.health - damage;
        }
        public Thief(int damage)
        {
            this.damage = damage;
        }
    }
}
