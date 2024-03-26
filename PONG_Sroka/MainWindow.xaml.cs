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
using System.Windows.Threading;

namespace PONG_Sroka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        Ball ball;
        Player mousePlayer, keyboardPlayer;

        public MainWindow()
        {
            InitializeComponent();
            ball = new(10, 10, MainCanavs);
            mousePlayer = new(MainCanavs, 10, 100, new SolidColorBrush(Colors.White), false);
            keyboardPlayer = new(MainCanavs, 10, 100, new SolidColorBrush(Colors.White), true);
            timer = new();
            timer.Interval = TimeSpan.FromMilliseconds(16);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void UpdateScores()
        {
            KeyboardPlayer.Content = keyboardPlayer.Points.ToString();
            MousePlayer.Content = mousePlayer.Points.ToString();
        }
    }
}