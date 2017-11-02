using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mega_card_game_2000
{
    /// <summary>
    /// Interaction logic for Battle.xaml
    /// </summary>
    public partial class Battle : Page
    {
        Warrior warrior;

        public Battle(string pClass, string pInputName)
        {
            InitializeComponent();
            BattleNames.Content = pInputName + " vs " + "Pixie";
            switch (pClass)
            {
                case "Warrior":
                       Warrior warrior = new Warrior(10);
                    break;
                default:
                    break;
            }
            GameController gameController = new GameController();

        }

        private void specialAttack_Click(object sender, RoutedEventArgs e)
        {
            //comment out this to get it to run
            warrior.AttackSpecial(pTarget);
            
        }

        private void normalAttack_Click(object sender, RoutedEventArgs e)
        {
            //comment out this to get it to run
            warrior.normalAttack(pTarget);
        }
    }
}
