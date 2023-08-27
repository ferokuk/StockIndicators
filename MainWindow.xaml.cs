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
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    class AppFrame
    {
        public static Frame frameMain;
    }
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            AppFrame.frameMain = frame;
            frame.Navigate(new StartPage());
            
        }

       
    }
}
