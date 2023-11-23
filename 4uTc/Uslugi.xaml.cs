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

namespace _4uTc
{
    /// <summary>
    /// Логика взаимодействия для Uslugi.xaml
    /// </summary>
    public partial class Uslugi : Page
    {
            public Uslugi()
            {
                InitializeComponent();
                cheutc.ItemsSource = demoekzamen1Entities1.GetContext().Materials.ToList();
            var currentMaterials = demoekzamen1Entities1.GetContext().Materials.ToList();
            
        }

        private void ButtonClick_Click(object sender, RoutedEventArgs e)
        {

        }
    }


  
    
}