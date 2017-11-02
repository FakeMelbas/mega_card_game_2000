using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_card_game_2000
{
    public class PlayerCharacter : Character
    {
        PlayerCharacterType type;

        public void Attack(NonPlayerCharacter pTarget)
        {
            pTarget.health = pTarget.health - damage;
            
        }

        public void AttackSpecial(NonPlayerCharacter pTarget)
        {
            pTarget.health = pTarget.health - damage;
        }

        public void playerCharacter(string name, int health, int damage, string pClass)
        {
            throw new NotImplementedException();
        }
    }
  }

