using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
using LMS3_GUIproject.INFORMATION;
using static System.Net.WebRequestMethods;

namespace LMS3_GUIproject
{
    /// <summary>
    /// UserPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UserPage : Page
    {

        public List<string> PakageList { get; set; } = new List<string>()
        {
            "기본(베이직)",
            "초음파 정밀(골드1)",
            "대장 정밀(골드2)",
            "뇌 정밀(노블1)",
            "심장 정밀(노블2)",
            "뇌심혈관 정밀(플래티넘1)",
            "뇌심혈관 정밀(플래티넘2)"
        };

        public List<string> MoneyList { get; set; } = new List<string>()
        {
            "30만원",
            "50만원",
            "50만원",
            "90만원",
            "90만원",
            "150만원",
            "200만원"
        };

        public UserPage()
        {
            InitializeComponent();
            combo_pakage.ItemsSource = PakageList;

        }

        User userpage = new User();

        private void Btn_accept_Click(object sender, RoutedEventArgs e)
        {
            userpage.Name = txt_name.Text;
            User.infolist[2] = txt_name.Text;

            userpage.Identity_Num1 = int.Parse(txt_identity.Text);
            User.infolist[3] = txt_identity.Text;

            userpage.Identity_Num2 = int.Parse(pw_identity.Password.ToString());
            User.infolist[4] = pw_identity.Password.ToString();

            userpage.PhNum = txt_phnum.Text;
            User.infolist[5] = txt_phnum.Text;

            userpage.Addr1 = txt_addr.Text;
            User.infolist[6] = txt_addr.Text;

            if (String.IsNullOrEmpty(txt_addr2.Text))
            {
                User.infolist[7] = "";
            }
            else
            {
                User.infolist[7] = txt_addr2.Text;
            }

            NavigationService.Navigate(new Uri("/Payxaml.xaml", UriKind.Relative));
        }

        private void date_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            string msg = "검진 날짜 " + date.SelectedDate.Value.ToString("yyyy-MM-dd") + "\n 등록";

            if (MessageBox.Show(msg, "건강검진 날짜 선택", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                userpage.Date = date.SelectedDate.Value.ToString("yyyy-MM-dd");
                txt_date.Text = userpage.Date;
                User.infolist[8] = date.SelectedDate.Value.ToString("yyyy-MM-dd");
            }
            else
            {
                MessageBox.Show("다시 날짜를 선택해주시길 바랍니다.");
                txt_date.Text = "";
            }
        }

        private void combo_pakage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbl_pakage.Content = combo_pakage.SelectedItem.ToString();
            User.infolist[1] = combo_pakage.SelectedItem.ToString();

            
            for(int i = 0; i < 7; i++)
            {
                if (combo_pakage.SelectedItem.ToString() == PakageList[i])
                {
                    lbl_money.Content = MoneyList[i];
                    User.infolist[0] = MoneyList[i];
                }
            }
        }
    }
}
