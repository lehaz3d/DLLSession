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
using VIN_LIB;
using REG_MARK_LIB;

namespace WpfSessia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnTrueFalse_Click(object sender, RoutedEventArgs e)
        {
            if (TbNameVin.Text != "" && TbGosNumber.Text == "")
            {
                bool boolVin = VIN_LIB.VIN_LIB.CheckVIN(TbNameVin.Text.ToLower());
                int numberYear = VIN_LIB.VIN_LIB.GetTransportYear(TbNameVin.Text.ToLower());
                string countryName = VIN_LIB.VIN_LIB.GetVINCountry(TbNameVin.Text.ToLower());
                MessageBox.Show(boolVin ? "Верный VIN" : "Неверный VIN", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
                TbYear.Text = "Год выпуска авто:" + " " + numberYear;
                TbCountry.Text = "Континент производитель:" + " " + countryName;
            }
            else if (TbNameVin.Text == "" && TbGosNumber.Text != "")
            {
                bool boolNumber = REG_MARK_LIB.REG_MARK_LIB.CheckMark(TbGosNumber.Text);
                MessageBox.Show(boolNumber ? "Верный ГОСНОМЕР" : "Неверный ГОСНОМЕР", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (TbNameVin.Text != "" && TbGosNumber.Text != "")
            {
                MessageBox.Show("Нужно заполнить ОДИН из блоков заполнения");
                return;
            }
        }
    }
}
