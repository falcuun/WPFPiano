using System.IO;
using System.Windows;


namespace PianoTry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Media.SoundPlayer player;

        public MainWindow()
        {
            InitializeComponent();
        }
        UnmanagedMemoryStream[] notes = { Properties.Resources.Piano_pp_F3,
            Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 ,
            Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 ,
            Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 ,
            Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 ,
            Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 ,
            Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 , Properties.Resources.Piano_pp_F3 ,
            Properties.Resources.Piano_pp_F3};
        private void C1_Sound(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_F3);
            player.Play();
        }

        private void C_Sharp_1(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_Db3);
            player.Play();
        }

        private void D1_Sound(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_C4);
            player.Play();
        }

        private void DSharp1_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_Db4);
            player.Play();
        }

        private void E1_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_D4);
            player.Play();
        }

        private void F1_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_E4);
            player.Play();
        }

        private void FSharp1_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_Db5);
            player.Play();
        }

        private void G1_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_G4);
            player.Play();
        }

        private void GSharp1_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_Eb3);
            player.Play();
        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_A4);
            player.Play();
        }

        private void ASharp1_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_Eb4);
            player.Play();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_B4);
            player.Play();
        }

        private void C2_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_C5);
            player.Play();
        }

        private void D2_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_D5);
            player.Play();
        }

        private void DSharp2_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_Eb5);
            player.Play();
        }

        private void E2_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_E5);
            player.Play();
        }

        private void F2_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_F4);
            player.Play();
        }

        private void FSharp2_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_C4);
            player.Play();
        }

        private void G2_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_G5);
            player.Play();
        }

        private void GSharp2_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_C4);
            player.Play();
        }

        private void ASharp2_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_C4);
            player.Play();
        }

        private void C3_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_C6);
            player.Play();
        }

        private void D3_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_D6);
            player.Play();
        }

        private void E3_Click(object sender, RoutedEventArgs e)
        {
            player = new System.Media.SoundPlayer(Properties.Resources.Piano_pp_E6);
            player.Play();
        }
    }
}
