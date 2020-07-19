using Entekhab_Vahed_Wpf.Config;
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

namespace Entekhab_Vahed_Wpf
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        EVContext db = new EVContext();
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text != null && txtPass.Password != null)
            {
                var q = db.Admins.Where(x => x.Username == txtUser.Text.Trim() && x.Password == txtPass.Password.Trim()).SingleOrDefault();

                if (q != null)
                {
                    new MainWindow().ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("نام کاربری و یا رمز عبور اشتباه می باشد");
                }
            }
            else
            {
                MessageBox.Show("نام کاربری و یا رمز عبور را وارد نمایید");
            }
        }
    }
}
