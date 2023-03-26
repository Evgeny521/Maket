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

namespace WpfAppRazrabotkaMaketa
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void AboutBut3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }

        private void AboutBut5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login=Login.Text.Trim();
            string pass=Password.Password.Trim();
            string pass_2=Password_2.Password.Trim();

            if (login.Length <= 5)
            {
                Login.ToolTip="Неверное поле";
                Login.Background = Brushes.Red;
            }
            else if(pass.Length <= 5)
            {
                Password.ToolTip = "Неверное поле";
                Password.Background = Brushes.Red;
            }
            else if(pass!=pass_2)
            {
                Password_2.ToolTip = "Неверное поле";
                Password_2.Background = Brushes.Red;
            }
            else
            {
                Login.ToolTip = "";
                Login.Background = Brushes.Transparent;
                Login.ToolTip = "";
                Login.Background = Brushes.Transparent;
                Login.ToolTip = "";
                Login.Background = Brushes.Transparent;

                MessageBox.Show("Вы прошли регистрацию!");
            }
            
            
        }   
    }
}
