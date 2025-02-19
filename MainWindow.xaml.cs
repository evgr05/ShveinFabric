using ShveinFabric.DataFiles;
using ShveinFabric.Pages;
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

namespace ShveinFabric
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DBClass.entObj = new ShveinFabricEntities();
            FrmClass.frmObj = new Frame();
            FrmClass.frmObj = frmMain;
            FrmClass.frmObj.Navigate(new PageLogin());
        }
    }
}
