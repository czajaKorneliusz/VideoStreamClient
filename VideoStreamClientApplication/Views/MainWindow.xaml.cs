using System.Windows;
using System.Windows.Forms.Integration;
using VideoStreamClientApplication.View_Models;

namespace VideoStreamClientApplication.Views
{
    /// <summary>
    ///     Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FormHostChildControl = FormsHost;
            Closing += delegate { MainWindowViewModel.StopVideoPlayer(); };
        }

        public static WindowsFormsHost FormHostChildControl { get; private set; }
    }
}