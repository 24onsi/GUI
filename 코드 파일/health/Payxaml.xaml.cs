using LMS3_GUIproject.INFORMATION;
using LMS3_GUIproject;
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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace health
{
    /// <summary>
    /// Payxaml.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Payxaml : Page
    {
        public Payxaml()
        {
            InitializeComponent();

            lbl_pakage.Content = User.infolist[0];
            lbl_money.Content = User.infolist[1];
            lbl_name.Content = User.infolist[2];
            lbl_identity.Content = User.infolist[3];
            lbl_phnum.Content = User.infolist[5];
            lbl_addr.Content = User.infolist[6];
            lbl_addr2.Content = User.infolist[7];
            lbl_date.Content = User.infolist[8];

        }

        private void Btn_pay_Click(object sender, RoutedEventArgs e)
        {
            string msg = "검진 금액 : " + User.infolist[1] + "입니다.\n결제하시겠습니까?";
            if (MessageBox.Show(msg, "결제 진행", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("결제가 완료되었습니다.\n예약 정보가 문자로 발송됩니다.");
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
            else
            {
                 // 현재 창 유지
            }
        }

        private void Btn_close_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("검진 예약 진행을 취소하시겠습니까?", "예약 진행 취소", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("예약 진행이 취소되었습니다.");
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
            else
            {
                // 현재 창 유지
            }
        }
    }
}
