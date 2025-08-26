using Characters;
using Characters.PMC;
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

namespace HeroQuest.UI.WPF.Pages.Character
{
    /// <summary>
    /// Interaction logic for CharacterCreationTest.xaml
    /// </summary>
    public partial class CharacterCreationTest : Page
    {
        private PlayerManager _playerManager; // Instance of your PlayerManager
        private Player _currentlyLoadedPlayer; // To keep track of the player being viewed/edited
        private PlayerFactory _playerFactory;

        public CharacterCreationTest()
        {
            InitializeComponent();
            
        }

        private void SaveNewCharacter(string name)
        {

        }


        private void DeleteSelectedPlayer(Guid id) 
        {
            _playerManager.DeletePlayer(id);
        }
        private void DeleteSelectedPlayers() 
        { 
            _playerManager.DeleteAllPlayers();
        }
       
    }
}
