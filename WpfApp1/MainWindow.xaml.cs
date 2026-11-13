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
using WpfApp1.Classes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Fighter fighterBasic = new Fighter("Боец", 100);
        private Fighter fighterLight = new LightFighter("Боец в лёгких доспехах", 100);
        private Fighter fighterHeavy = new HeavyFighter("Боец в тяжёлых доспехах", 100);

        private Opponent opponentBoss = new Opponent("Тёмный рыцарь", 20);

        public MainWindow()
        {
            InitializeComponent();
            RefreshUI();
        }

        private void BtnAttack_Click(object sender, RoutedEventArgs e)
        {
            fighterBasic.ApplyDamage(opponentBoss.OpponentDamage);
            fighterLight.ApplyDamage(opponentBoss.OpponentDamage);
            fighterHeavy.ApplyDamage(opponentBoss.OpponentDamage);
            RefreshUI();
        }

        private void RefreshUI()
        {
            lblBasicHealth.Content = $"Здоровье: {fighterBasic.HealthCurrent} / {fighterBasic.HealthMax}";
            lblLightHealth.Content = $"Здоровье: {fighterLight.HealthCurrent} / {fighterLight.HealthMax}";
            lblHeavyHealth.Content = $"Здоровье: {fighterHeavy.HealthCurrent} / {fighterHeavy.HealthMax}";

            lblEnemyName.Content = opponentBoss.OpponentName;
            lblEnemyDamage.Content = $"Урон: {opponentBoss.OpponentDamage}";
        }
    }
}
