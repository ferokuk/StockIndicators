using Skender.Stock.Indicators;
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

namespace StockIndicators
{
    /// <summary>
    /// Логика взаимодействия для CurrencyAccounts.xaml
    /// </summary>
    public partial class GOOGLPage : Page
    {
        public GOOGLPage()
        {
            InitializeComponent();
            using (DBConnection conn = new DBConnection())
            {
                var res = conn.GOOGL.ToList().GetBop().Where(r => !string.IsNullOrEmpty(r.Bop.ToString())).ToList();
                grid.ItemsSource = res;
            }
            
        }
        private void BackButton(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }
    }
}
