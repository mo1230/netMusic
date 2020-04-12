using netMusic.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace netMusic
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private PageManage pageManage = new PageManage();
        private MainPage mainPage = new MainPage();
        public MainPage MainPage { 
            get {
                return mainPage;
            } 
            set {
                mainPage = value;
            } 
        }
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnMax_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void AppHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnFind_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Content = pageManage.FindMusicPage;
            
        }

        private void BtnFM_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Content = pageManage.FMPage;
        }

        private void BtnLOOK_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Content = pageManage.LOOKPage;
        }

        private void BtnVideo_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Content = pageManage.VideoPage;
        }

        private void BtnFriend_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Content = pageManage.FriendPage;
        }

        private void BtnLocalMusic_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Content = pageManage.LocalMusicPage;
        }

        private void BtnDownload_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Content = pageManage.DownloadPage;
        }
    }
}
