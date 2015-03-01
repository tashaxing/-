using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace 电子路考仪
{
    public partial class video : PhoneApplicationPage
    {
        public video()
        {
            InitializeComponent();
        }

        private void btnvideo1(object sender, RoutedEventArgs e)
        {
            WebBrowserTask wt1 = new WebBrowserTask();
            wt1.Uri = new Uri("http://pan.baidu.com/s/1bnnEP4N", UriKind.Absolute);
            wt1.Show();
        }

        private void btnvideo2(object sender, RoutedEventArgs e)
        {
            WebBrowserTask wt2 = new WebBrowserTask();
            wt2.Uri = new Uri("http://pan.baidu.com/s/1bnsy7Yv", UriKind.Absolute);
            wt2.Show();
        }
    }
}