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
            (Resources["AnimPulse"] as Storyboard).Completed += Pulse_Completed;
        }

        private void Pulse_Completed(object sender, EventArgs e)
        {
            (Resources["AnimPulse"] as Storyboard).Begin();
        }

        private void Refresh_anim(object sender, EventArgs e)
        {
            (Resources["AnimBooster"] as Storyboard).Begin();
        }
    }
}
