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

namespace DZ6_NickPustovoy_IVT21B_VAR2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cb1_Loaded(object sender, RoutedEventArgs e)
        {
            Cb1.Items.Add("Доллар");
            Cb1.Items.Add("Евро");
            Cb1.Items.Add("Юань");
        }

        private void Btad_Click(object sender, RoutedEventArgs e)
        {
            if (Cb1.Text == "Доллар")
            {
                Dollar ad = new Dollar(Convert.ToInt32(Tb1.Text));
                TextList.Items.Add(ad.getAmount().ToString() + " $ = " + ad.getinRubles().ToString() + " ₽");
                /*foreach (string i in TextList.Items) 
                {
                    
                }*/
            }
            if (Cb1.Text == "Евро")
            {
                Euro ad = new Euro(Convert.ToInt32(Tb1.Text));
                TextList.Items.Add(ad.getAmount().ToString() + " € = " + ad.getinRubles().ToString() + " ₽");
            }
            if (Cb1.Text == "Юань")
            {
                Yuan ad = new Yuan(Convert.ToInt32(Tb1.Text));
                TextList.Items.Add(ad.getAmount().ToString() + " ㍐ = " + ad.getinRubles().ToString() + " ₽");
            }
        }
    }
}
