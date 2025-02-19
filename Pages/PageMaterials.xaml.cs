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
    /// Логика взаимодействия для PageMaterials.xaml
    /// </summary>
    public partial class PageMaterials : Page
    {
        public PageMaterials()
        {
            InitializeComponent();
            matGrid.ItemsSource = DBClass.entObj.Textile.ToList();
        }

        private void bckBtn_Click(object sender, RoutedEventArgs e)
        {
            FrmClass.frmObj.Navigate(new PageMenu());
        }



        private void matGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DBClass.entObj.SaveChanges();
            matGrid.ItemsSource = DBClass.entObj.Textile.ToList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
