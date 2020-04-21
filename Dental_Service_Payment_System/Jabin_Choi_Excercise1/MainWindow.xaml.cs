using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

namespace Jabin_Choi_Excercise1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string name;
        public string address;
        public string province;
        public string ageCategory;
        public double taxRate;
        public double discount;
        public double price = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void comboBoxProvince_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if(comboBox != null)
            {
                ComboBoxItem item = comboBox.SelectedItem as ComboBoxItem;
                if(item != null)
                {
                    province = item.Content.ToString();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name = txtName.Text;
            address = txtAddress.Text;

            if (checkBoxFlossing.IsChecked == true)
                price += 20;
            if (checkBoxFilling.IsChecked == true)
                price += 75;
            if (checkBoxRootCanal.IsChecked == true)
                price += 150;

            if (province == "Alberta")
                taxRate = 1.07;
            if (province == "Ontario")
                taxRate = 1.13;
            if (province == "Quebec")
                taxRate = 1.06;

            if(radioSenior.IsChecked == true)
            {
                ageCategory = "Senior";
                discount = 0.10;
            }
            if (radioKidsYouth.IsChecked == true)
            {
                ageCategory = "Kids and Youth";
                discount = 0.15;
            }
            if(radioAdult.IsChecked == true)
            {
                ageCategory = "Adult";
            }

            // Display - MessageBox
            MessageBox.Show("[Patient Information] \n\n" +
                        "* Name: " + name + "\n" +
                        "* Address: " + address + "\n" +
                        "* Province: " + province + "\n" +
                        "* Age Category: " + ageCategory + "\n\n" +
                        "Totoal Price: $" + (price * taxRate * (1 - discount)).ToString()
                        , "Results", MessageBoxButton.OK, MessageBoxImage.Information);

            Application.Current.Shutdown();
        }

        
    }
}
