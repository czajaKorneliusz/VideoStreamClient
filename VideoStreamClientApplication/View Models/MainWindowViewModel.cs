using AForge.Controls;
using AForge.Video;
using VideoStreamClientApplication.Views;

namespace VideoStreamClientApplication.View_Models
{
    internal class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            VPlayer = new VideoSourcePlayer();
            StartButtonCommand = new RelayCommand(x => OpenVideoSource(MjpegSource));
            StopButtonCommand = new RelayCommand(x => VPlayer.WaitForStop());
        }

        private static VideoSourcePlayer VPlayer { get; set; }

        public MJPEGStream MjpegSource { get; set; }
        //=new MJPEGStream("http://217.197.157.7:7070/axis-cgi/mjpg/video.cgi?resolution=320x240");

        public RelayCommand StartButtonCommand { get; set; }
        public RelayCommand StopButtonCommand { get; set; }

        public static void StopVideoPlayer()
        {
            if (VPlayer.IsRunning) VPlayer.Stop();
        }


        private void OpenVideoSource(IVideoSource source)
        {
            if (MainWindow.FormHostChildControl.Child == null) MainWindow.FormHostChildControl.Child = VPlayer;

            if (MjpegSource == null || string.IsNullOrEmpty(source.Source)) return;

            VPlayer.VideoSource = source;
            VPlayer.Start();
        }
    }
}