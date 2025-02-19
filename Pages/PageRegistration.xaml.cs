using ShveinFabric.DataFiles;
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
using UserRegistration;

namespace ShveinFabric.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        int passRezult;
        public PageRegistration()
        {
            InitializeComponent();
            
            errTxb.Content = "Пароль не может быть пустым";
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (txbLogin.Text.Length == 0)
                errors.AppendLine("Введите логин");
            if (txbName.Text.Length == 0)
                errors.AppendLine("Введите имя");
            if (psbPassword.Password.Length == 0 || psbPassword2.Password.Length == 0)
            {
                if (psbPassword.Password != psbPassword2.Password)
                    errors.AppendLine("Пароли не совпадают");
                else
                    errors.AppendLine("Введите пароль");
            }
            if (passRezult < 3)
            {
                errors.AppendLine("Папрль слишком простой, придумайте посложнее!");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (errors.Length == 0)
            {
                var userObj = new Users()
                {
                    Login = txbLogin.Text,
                    Name = txbName.Text,
                    Password = psbPassword.Password,
                };
                DBClass.entObj.Users.Add(userObj);
                DBClass.entObj.SaveChanges();
                MessageBox.Show("Пользователь успешно зарегистрирован");
                FrmClass.frmObj.Navigate(new PageLogin());
                
                
            }

        }



        private void psbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (psbPassword.Password == psbPassword2.Password)
            {
                if (psbPassword.Password.Length > 3)
                {
                    passRezult = PasswordStrengthChecker.GetPasswordStrengthChecker(psbPassword.Password);
                    passwordProgress.Value = passRezult;
                    if (passwordProgress.Value < 3)
                    {
                        errTxb.Content = "Пароль слишком простой";
                    }
                    if (passwordProgress.Value == 3)
                    {
                        errTxb.Content = "Средний пароль";
                    }
                    if (passwordProgress.Value > 3)
                    {
                        errTxb.Content = "Хороший пароль";
                    }
                }
                if (psbPassword.Password.Length <= 3)
                {
                    errTxb.Content = "Нужно минимум 4 символа";
                }
                if (psbPassword.Password.Length == 0)
                {
                    errTxb.Content = "Пароль не может быть пустым";
                }
            }
            else
            {
                errTxb.Content = "Пароли не совпадают!";
                passwordProgress.Value = 0;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrmClass.frmObj.Navigate(new PageLogin());
        }
    }
}
