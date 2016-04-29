using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace WPFBoosterPick
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB db = new DB();

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
            db.epic_count++;
            EpicCount.Text = db.epic_count.ToString();
        }

        private void button_plus_leg_Click(object sender, RoutedEventArgs e)
        {
            Refresh_Pulse();
            db.leg_count++;
            LegCount.Text = db.leg_count.ToString();
        }

        private void button_plus_gold_com_Click(object sender, RoutedEventArgs e)
        {
            Refresh_Pulse();
            db.g_com_count++;
            GoldComCount.Text = db.g_com_count.ToString();
        }

        private void button_plus_gold_rare_Click(object sender, RoutedEventArgs e)
        {
            Refresh_Pulse();
            db.g_rare_count++;
            GoldRareCount.Text = db.g_rare_count.ToString();
        }

        private void button_plus_gold_epic_Click(object sender, RoutedEventArgs e)
        {
            Refresh_Logo();
            db.g_epic_count++;
            GoldEpicCount.Text = db.g_epic_count.ToString();
        }

        private void button_plus_gold_leg_Click(object sender, RoutedEventArgs e)
        {
            Refresh_Logo();
            db.g_leg_count++;
            GoldLegCount.Text = db.g_leg_count.ToString();
        }

        private void button_minus_epic_Click(object sender, RoutedEventArgs e)
        {
            db.epic_count--;
            EpicCount.Text = db.epic_count.ToString();
        }

        private void button_minus_leg_Click(object sender, RoutedEventArgs e)
        {
            db.leg_count--;
            LegCount.Text = db.leg_count.ToString();
        }

        private void button_minus_gold_com_Click(object sender, RoutedEventArgs e)
        {
            db.g_com_count--;
            GoldComCount.Text = db.g_com_count.ToString();
        }

        private void button_minus_gold_rare_Click(object sender, RoutedEventArgs e)
        {
            db.g_rare_count--;
            GoldRareCount.Text = db.g_rare_count.ToString();
        }

        private void button_minus_gold_epic_Click(object sender, RoutedEventArgs e)
        {
            db.g_epic_count--;
            GoldEpicCount.Text = db.g_epic_count.ToString();
        }

        private void button_minus_gold_leg_Click(object sender, RoutedEventArgs e)
        {
            db.g_leg_count--;
            GoldLegCount.Text = db.g_leg_count.ToString();
        }
    }
}
