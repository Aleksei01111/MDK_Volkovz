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
using System.Windows.Shapes;

namespace MDK_Volkov
{
    /// <summary>
    /// Interaction logic for WinRegister.xaml
    /// </summary>
    public partial class WinRegister : Window
    {
        public WinRegister()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            if(PasswordPsb.Password != ReTryPasswordPsb.Password)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var s = new Student(NameTxb.Text, PasswordPsb.Password);
            MessageBox.Show("Запись создана успешно!", "Ура", MessageBoxButton.OK, MessageBoxImage.Information);
            DialogResult = true;
        }
    }
}
