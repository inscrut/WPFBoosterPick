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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFBoosterPick
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            (Resources["AnimBooster"] as Storyboard).Completed += new EventHandler(Refresh_anim);
        }

        private void Refresh_anim(object sender, EventArgs e)
        {
            (Resources["AnimBooster"] as Storyboard).Begin();
        }
        private void Refresh_Pulse()
        {
            (Resources["AnimPulse"] as Storyboard).Begin();
        }
        private void Refresh_Logo()
        {
            (Resources["LightLogo"] as Storyboard).Begin();
        }

        private void button_plus_epic_Click(object sender, RoutedEventArgs e)
        {
            Refresh_Pulse();
        }

        private void button_plus_leg_Click(object sender, RoutedEventArgs e)
        {
            Refresh_Pulse();
        }

        private void button_plus_gold_com_Click(object sender, RoutedEventArgs e)
        {
            Refresh_Pulse();
        }

        private void button_plus_gold_rare_Click(object sender, RoutedEventArgs e)
        {
            Refresh_Pulse();
        }

        private void button_plus_gold_epic_Click(object sender, RoutedEventArgs e)
        {
            Refresh_Logo();
        }

        private void button_plus_gold_leg_Click(object sender, RoutedEventArgs e)
        {
            Refresh_Logo();
        }
    }
}
