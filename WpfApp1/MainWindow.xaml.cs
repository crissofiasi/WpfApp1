using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        void clearWindow()
        {
            lblInfo.Content = "";
            lblResults.Content = "";
            txtDate.Text = "";
        }

        private void rbSalut_Checked(object sender, RoutedEventArgs e)
        {
            clearWindow();
            lblInfo.Content = "Introduceti Numele";
        }

        private void rbMedia_Checked(object sender, RoutedEventArgs e)
        {
            clearWindow();
            lblInfo.Content = "Introduceti Numerele";
        }

        private void rbPalindrom_Checked(object sender, RoutedEventArgs e)
        {
            clearWindow();
            lblInfo.Content = "Introduceti cuvantul";
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            HandleUserInput(txtDate.Text);
        }

        private void HandleUserInput(string input)
        {
            foreach (RadioButton rb in wpRadioButons.Children)
            {
                if (rb.IsChecked == true)
                {
                    string rbname = rb.Name;
                    switch (rbname)
                    {
                        case "rbSalut":
                            handleSalut(input);
                            break;
                        case "rbMedia":
                            handleMedia(input);
                            break;
                        case "rbPalindrom":
                            handlePalindrom(input);
                            break;
                        default:
                            lblInfo.Content = "Functie handele neimplementata!";
                            break;

                    }
                    return;
                }
            }
            lblInfo.Content = "<--- Va rog selectati o varianta!";
        }

        private void handlePalindrom(string input)
        {
            //citirea datelor
            //validare
            if (string.IsNullOrEmpty(input))
            {
                lblInfo.Content = "nu ati introdus numic! Va rog sa introduceti un cuvant";
                return;
            }

            //calcul
            Cuvant cuv = new Cuvant(txtDate.Text);

            bool isP = cuv.IsPalindrom();

            //afisare
            if (isP)
                lblResults.Content = "Este palindrom";
            else
                lblResults.Content = "Nu este palindrom";
        }

        private void handleMedia(string input)
        {
            //citire date
            //validare 1
            if (string.IsNullOrEmpty(input))
            {
                lblInfo.Content = "Nu ati introdus numic! Va rog sa introduceti numerele";
                return;
            }
            //validare 2
            List<int> numere = input.textToNumbers();
            if (numere == null)
            {
                lblInfo.Content = lblResults.Content = "Introduceti doar numere intregi";
                return;
            }
            //calcul
            double medie = Utils.calculMedie(numere);
            //afisare

            lblResults.Content =   medie.ToString("f2");
        }

        private void handleSalut(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                lblInfo.Content = "Nu ati introdus numic! Va rog sa introduceti numele:";
                return;

            }
            Cuvant cuv = new Cuvant(txtDate.Text);
            lblResults.Content = cuv.generateHello();
        }
        
        private void lblInfo_Loaded(object sender, RoutedEventArgs e)
        {
            clearWindow();
            lblInfo.Content = "<--- Selectati o varianta";
        }       
    }
}
