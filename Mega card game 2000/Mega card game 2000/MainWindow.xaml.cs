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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        private string inputName;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void WarriorButton_Click(object sender, RoutedEventArgs e)
        {
            inputName = getName.Text;
            Battle battle = new Battle("Warrior", inputName);
            NavigationService.Navigate(battle);
            
        }

        private void ThiefButton_Click(object sender, RoutedEventArgs e)
        {
            inputName = getName.Text;
            Battle battle = new Battle("Thief", inputName);
            NavigationService.Navigate(battle);


        }

        private void MageButton_Click(object sender, RoutedEventArgs e)
        {
            inputName = getName.Text;
            Battle battle = new Battle("Mage", inputName);
            NavigationService.Navigate(battle);
        }
    }
}
