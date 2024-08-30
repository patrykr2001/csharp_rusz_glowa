﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KalkulatorObrazen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        SwordDamage swordDamage;

        public MainWindow()
        {
            InitializeComponent();
            swordDamage = new(Roll3D6());
            RollDice();
        }

        private int Roll3D6() 
        {
            return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
        }

        private void RollDice()
        {
            swordDamage.Roll = Roll3D6();
            swordDamage.Flaming = flaming.IsChecked.Value;
            swordDamage.Magic = magic.IsChecked.Value;
            DisplayDamage();
        }

        private void DisplayDamage()
        {
            damage.Text = "Rzut: " + swordDamage.Roll + ", punkty obrażeń: " + swordDamage.Damage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RollDice();
        }

        private void Flaming_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.Flaming = true;
            DisplayDamage();
        }

        private void Flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.Flaming = false;
            DisplayDamage();
        }

        private void Magic_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.Magic = true;
            DisplayDamage();
        }

        private void Magic_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.Magic = false;
            DisplayDamage();
        }
    }
}