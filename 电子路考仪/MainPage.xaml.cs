using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;
using Microsoft.Phone;

namespace 电子路考仪
{
    public partial class MainPage : PhoneApplicationPage
    {
        // 构造函数
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("您真的要离开吗?", "提示", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        } 
        private void btnplay(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/playsound.xaml", UriKind.Relative));

        }

        private void btntxt(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/txt.xaml", UriKind.Relative));

        }

        private void btnabout(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/about.xaml", UriKind.Relative));

        }

        private void btnhelp(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/help.xaml", UriKind.Relative));

        }

        private void btngood(object sender, RoutedEventArgs e)
        {
            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();

            marketplaceReviewTask.Show();

        }

        private void btngreen(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage;
            bitmapImage = new BitmapImage(new Uri("img/淡绿.jpg", UriKind.Relative));
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = bitmapImage;
            //设置Panorama控件的背景
            this.my_panorama.Background = imageBrush;

        }

        private void btnblue(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage;
            bitmapImage = new BitmapImage(new Uri("img/纯蓝.jpg", UriKind.Relative));
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = bitmapImage;
            //设置Panorama控件的背景
            this.my_panorama.Background = imageBrush;

        }
        private void btnroad(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmapImage;
            bitmapImage = new BitmapImage(new Uri("img/公路2.jpg", UriKind.Relative));
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = bitmapImage;
            //设置Panorama控件的背景
            this.my_panorama.Background = imageBrush;
        }

        private void btnskill(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/skill.xaml", UriKind.Relative));
        }

        private void btnvideo(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/video.xaml", UriKind.Relative));
        }

       

        

       
    }
}