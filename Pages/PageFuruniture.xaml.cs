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
    /// Логика взаимодействия для PageFuruniture.xaml
    /// </summary>
    public partial class PageFuruniture : Page
    {
        public PageFuruniture()
        {
            InitializeComponent();
            furGrid.ItemsSource = DBClass.entObj.Furuniture.ToList();
        }

        private void bckBtn_Click(object sender, RoutedEventArgs e)
        {
            FrmClass.frmObj.Navigate(new PageMenu());
        }

        private void furGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DBClass.entObj.SaveChanges();
            furGrid.ItemsSource = DBClass.entObj.Furuniture.ToList();
        }

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            FrmClass.frmObj.Navigate(new PageAddFuruniture());
        }
    }
}
