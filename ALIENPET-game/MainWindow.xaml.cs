using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ALIENPET_game
{
    
    public partial class MainWindow : Window
    {
        class PetData
        {
            public string Owner { get; set; }
            public string PetName { get; set; }
            public DateTime PetBirth { get; set; }
            public enum PetStage { Egg, Baby, Kid, Teen, Adult }
            public PetStage petstage { get; set; } = PetStage.Egg;
            public DateTime LastTimePlayed { get; set; }
        }

        class PetStats
        {
            private const int MIN = 0;
            private const int MAX = 100;
            public int Hunger { get; set; } = 0;
            public int Happiness { get; set; } = 0;
            public int Energy { get; set; } = 100;
            public int Health { get; set; } = 100;
            public int Discipline { get; set; } = 0;
            public int Cleanliness { get; set; } = 100;
            public void ClampStats()
            {
                Hunger = Math.Clamp(Hunger, 0, 100);
                Happiness = Math.Clamp(Happiness, 0, 100);
                Energy = Math.Clamp(Energy, 0, 100);
                Health = Math.Clamp(Health, 0, 100);
                Discipline = Math.Clamp(Discipline, 0, 100);
                Cleanliness = Math.Clamp(Cleanliness, 0, 100);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }


    }

}