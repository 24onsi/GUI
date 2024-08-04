using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace health
{
    /// <summary>
    /// result11.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class result11 : Page
    {
        public result11()
        {
            InitializeComponent();
        }

        private void Btn_search_Click(object sender, RoutedEventArgs e)
        {
            
            if(String.IsNullOrEmpty(result_txt_name.Text) || String.IsNullOrEmpty(result_txt_identity1.Text)
                || String.IsNullOrEmpty(result_pw_identity2.Password.ToString()))
            {
                MessageBox.Show("해당 정보를 모두 입력해주세요.");
            }
            else
            {
                MessageBox.Show("조회된 검진 결과가 없습니다.");
            }
        }

        private void Btn_out_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("메인화면으로 이동합니다.");
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}
