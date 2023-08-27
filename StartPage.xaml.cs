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
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new TSLAPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new GOOGLPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new MSFTPage());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new AAPLPage());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new UBERPage());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new WhatIsBOP());
        }
    }
}
