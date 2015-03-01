using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace 电子路考仪
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }
               
        private void l1(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示：前照灯→远光灯→近光灯→远光灯→近光灯→示宽灯+双闪→关闭灯光";
            sound.Source = new Uri("模拟灯光考试一.mp3", UriKind.Relative);
            sound.Play();
        }

        private void l2(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示：前照灯→远光灯→近光灯→远近灯光交替→近光灯→示宽灯+双闪→关闭灯光";
            sound.Source = new Uri("模拟灯光考试二.mp3", UriKind.Relative);
            sound.Play();
        }

        private void l3(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示：前照灯→远光灯→近光灯→远近灯光交替→雾灯+双闪→关闭灯光";
            sound.Source = new Uri("模拟灯光考试三.mp3", UriKind.Relative);
            sound.Play();
        }

        private void l4(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示：前照灯→远光灯→近光灯→远近灯光交替→示宽灯+双闪→关闭灯光";
            sound.Source = new Uri("模拟灯光考试四.mp3", UriKind.Relative);
            sound.Play();
        }

        private void qibu(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示：一踩，二挂，三打转向灯，四按喇叭，五看后视镜，六松手刹";
            sound.Source = new Uri("起步.mp3", UriKind.Relative);
            sound.Play();
        }

        private void zhi(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示：轻踩油门→踩离合器→挂三挡→踩油门将车速提高到35km/h左右";
            sound.Source = new Uri("直线行驶.mp3", UriKind.Relative);
            sound.Play();

        }

        private void jieshu(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示：缓松油门";
            sound.Source = new Uri("结束直线行驶.mp3", UriKind.Relative);
            sound.Play();
        }

        private void chaoche(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示:打左转向灯→看左后视镜→等待三秒→向左轻转方向盘→轻踩油门→方向盘回正→关闭转向灯";
            sound.Source = new Uri("前方超车.mp3", UriKind.Relative);
            sound.Play();
        }

        private void zuo(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示:轻踩刹车→减到二档→打左转向灯→看左后视镜→等待三秒→向左转方向盘";
            sound.Source = new Uri("前方路口左转.mp3", UriKind.Relative);
            sound.Play();
        }

        private void diaotou(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示:轻踩刹车→减到二档或一档→打左转向灯→看左后视镜→等待三秒→向左方向盘打满";
            sound.Source = new Uri("前方掉头.mp3", UriKind.Relative);
            sound.Play();
        }

        private void you(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示:轻踩刹车→减到二档→打右转向灯→看右后视镜→等待三秒→向右轻转方向盘";
            sound.Source = new Uri("前方路口右转.mp3", UriKind.Relative);
            sound.Play();
        }

        private void biandao(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示:打左转向灯→看左后视镜→等待三秒→向左轻转方向盘→轻踩油门→方向盘回正→关闭转向灯";
            sound.Source = new Uri("前方请变更车道.mp3", UriKind.Relative);
            sound.Play();
        }

        private void lukou(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示:踩刹车，遇到情况要鸣喇叭";
            sound.Source = new Uri("前方路口直行.mp3", UriKind.Relative);
            sound.Play();
        }

        private void bus(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示:踩刹车，遇到情况要鸣喇叭";
            sound.Source = new Uri("通过公交车站.mp3", UriKind.Relative);
            sound.Play();
        }

        private void school(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示:踩刹车，若有禁止鸣喇叭标志则不准鸣喇叭";
            sound.Source = new Uri("通过学校区域.mp3", UriKind.Relative);
            sound.Play();
        }

        private void ren(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示：踩刹车，适当减档，遇到行人要减速或停车让行";
            sound.Source = new Uri("通过人行横道.mp3", UriKind.Relative);
            sound.Play();
        }

        private void tingche(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示：踩刹车并稳住→打右转向灯→看右后视镜→等待三秒→向右轻转方向盘→对边线→方向盘回正→踩离合器→刹车缓慢踩到底停车";
            sound.Source = new Uri("靠边停车.mp3", UriKind.Relative);
            sound.Play();
        }

        private void schoolbus(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示：踩刹车→踩刹车";
            sound.Source = new Uri("通过学校-汽车站.mp3", UriKind.Relative);
            sound.Play();
        }

        private void slow(object sender, RoutedEventArgs e)
        {
            tip.Text = "提示：踩刹车→减档";
            sound.Source = new Uri("减速路段.mp3", UriKind.Relative);
            sound.Play();
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            tip.Text = "";
            sound.Stop();
        }
    }
}