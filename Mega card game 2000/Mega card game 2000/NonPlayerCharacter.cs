using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_card_game_2000
{
    public class NonPlayerCharacter : Character
    {
        string name;
        int health;
        int damage;

        public NonPlayerCharacter(string name, int health, int damage) : base ()
        {


        }


        public void Attack(PlayerCharacter pTarget)
        {
            pTarget.health = pTarget.health - damage;
        }


    }




}
