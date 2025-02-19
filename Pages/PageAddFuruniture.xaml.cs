using Microsoft.Win32;
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

namespace ShveinFabric.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddFuruniture.xaml
    /// </summary>
    public partial class PageAddFuruniture : Page
    {
        string path;
        Furuniture _currentFuruniture = new Furuniture();
        public PageAddFuruniture()
        {
            InitializeComponent();
            DataContext = _currentFuruniture;
        }

        private void imageBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            
            if(ofd.ShowDialog() == true)
            {
                path = ofd.FileName;
                txbfile.Text = $"Изображение: {path}";                
            }
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            _currentFuruniture.Image = path;
            DBClass.entObj.Furuniture.Add(_currentFuruniture);
            DBClass.entObj.SaveChanges();
            FrmClass.frmObj.Navigate(new PageFuruniture());
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            FrmClass.frmObj.Navigate(new PageFuruniture());
        }
    }
}
