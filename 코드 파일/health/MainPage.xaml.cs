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

namespace LMS3_GUIproject
{
    /// <summary>
    /// MainPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_exemination_Click(object sender, RoutedEventArgs e) 
        {
            NavigationService.Navigate(new Uri("/Program.xaml", UriKind.Relative));
        }

        private void Btn_map_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Map.xaml", UriKind.Relative));
        }

        private void Btn_booking_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UserPage.xaml", UriKind.Relative));
        }

        private void Btn_caution_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Caution.xaml", UriKind.Relative));
        }

        private void Btn_result_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/result11.xaml", UriKind.Relative));
        }

        private void Btn_doc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Paper.xaml", UriKind.Relative));
        }
    }
}
