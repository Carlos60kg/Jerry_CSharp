using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace JerryUploader
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        private string username = "1126874468@qq.com";
        private string password = "jerry";

        public LoginWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (user_Email.Text == username && user_Password.Text == password)
            {
                FileShowWindow fileShow = new FileShowWindow();
                fileShow.Show();
                Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Please enter the correct username or password");
            }
        }


        AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

        private void TextBox_EmailTextChanged(object sender, TextChangedEventArgs e)
        {
            //AutoCompleteMode a = System.Windows.Forms.AutoCompleteMode.Suggest;
            user_Email.AutoWordSelection = true;
        }

        private void TextBox_PasswordTextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
