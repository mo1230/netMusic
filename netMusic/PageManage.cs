using netMusic.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netMusic
{
    class PageManage 
    {
        private DownloadPage downloadPage;
        private FindMusicPage findMusicPage;
        private FMPage fMPage;
        private FriendPage friendPage;
        private LocalMusicPage localMusicPage;
        private LOOKPage lOOKPage;
        private MainPage mainPage;
        private VideoPage videoPage;

        public PageManage()
        {
            this.downloadPage = new DownloadPage();
            this.findMusicPage = new FindMusicPage();
            this.fMPage = new FMPage();
            this.friendPage = new FriendPage();
            this.localMusicPage = new LocalMusicPage();
            this.lOOKPage = new LOOKPage();
            this.mainPage = new MainPage();
            this.videoPage = new VideoPage();
        }

        public DownloadPage DownloadPage
        {
            get
            {
                return downloadPage;
            }
            set
            {
                downloadPage = value;
            //    OnPropertyChanged(new PropertyChangedEventArgs("DownloadPage"));
            }
        }

        public FindMusicPage FindMusicPage { get => findMusicPage; set => findMusicPage = value; }
        public FMPage FMPage { get => fMPage; set => fMPage = value; }
        public FriendPage FriendPage { get => friendPage; set => friendPage = value; }
        public LocalMusicPage LocalMusicPage { get => localMusicPage; set => localMusicPage = value; }
        public LOOKPage LOOKPage { get => lOOKPage; set => lOOKPage = value; }
        public MainPage MainPage { get => mainPage; set => mainPage = value; }
        public VideoPage VideoPage { get => videoPage; set => videoPage = value; }

     
    }
}
