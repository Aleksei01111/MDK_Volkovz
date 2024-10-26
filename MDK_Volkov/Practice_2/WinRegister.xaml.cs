using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        private readonly Student _studentResult;
        public WinRegister(Student studentResult)
        {
            _studentResult = studentResult;
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            if(PasswordPsb.Password != ReTryPasswordPsb.Password)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if(NameTxb.Text == "" || PasswordPsb.Password == "")
            {
                MessageBox.Show("Поля не нада пусто делат", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            _studentResult.Name = NameTxb.Text;
            _studentResult.Password = PasswordPsb.Password;
            DialogResult = true;
        }
    }
}
