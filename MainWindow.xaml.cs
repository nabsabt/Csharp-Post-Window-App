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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var button = (Button)sender;
            if(TBname.Text != "" && TBtitle.Text != "" && TBpostText.Text != "" && LsentName1.Content == "")
            {
                DateTime currentDate =  DateTime.Now;
                LsentName1.Content = TBname.Text;
                TBname.Clear();
                LsentTitle1.Content = TBtitle.Text;
                TBtitle.Clear();
                TblockSentPost1.Text = TBpostText.Text;
                TBpostText.Clear();
                Ldate1.Visibility = Visibility.Visible;
                Ldate1.Content = currentDate;

                LnameWarning.Visibility = Visibility.Hidden;
                LtitleWarning.Visibility = Visibility.Hidden;
                BdeletePost1.Visibility = Visibility.Visible;


            }
            else if(TBname.Text != "" && TBtitle.Text != "" && TBpostText.Text != "" && LsentName1.Content != "")
            {
                if(LsentName2.Content != "")
                {
                    MessageBox.Show("This will overwrite the last post!");

                }
                DateTime currentDate = DateTime.Now;
                LsentName2.Content = TBname.Text;
                TBname.Clear();
                LsentTitle2.Content = TBtitle.Text;
                TBtitle.Clear();
                TblockSentPost2.Text = TBpostText.Text;
                TBpostText.Clear();
                Ldate2.Visibility = Visibility.Visible;
                Ldate2.Content = currentDate;

                LnameWarning.Visibility = Visibility.Hidden;
                LtitleWarning.Visibility = Visibility.Hidden;
                BdeletePost1.Visibility = Visibility.Visible;
                BdeletePost2.Visibility = Visibility.Visible;

            }

            else if(TBname.Text == "")
            {
                LnameWarning.Visibility = Visibility.Visible;
            }
            else if (TBtitle.Text == "")
            {
                LtitleWarning.Visibility = Visibility.Visible;
            }
        }

        private void TBname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        
        private void BdeletePost1_Click(object sender, RoutedEventArgs e)
        {
            LsentName1.Content = "";
            LsentTitle1.Content = "";
            TblockSentPost1.Text = "";
            Ldate1.Content = "";
            BdeletePost1.Visibility = Visibility.Hidden;
                

        }

        private void BdeletePost2_Click(object sender, RoutedEventArgs e)
        {
            LsentName2.Content = "";
            LsentTitle2.Content = "";
            TblockSentPost2.Text = "";
            Ldate2.Content = "";
            BdeletePost2.Visibility = Visibility.Hidden;
        }

       
    }

}
