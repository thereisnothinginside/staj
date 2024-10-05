using System;
using System.Windows;
using System.Windows.Threading;

namespace widget_1
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            // Saat güncelleyici zamanlayıcıyı başlat
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateClock;
            timer.Start();

            // Saatin ilk güncellenmesini tetikle
            UpdateClock(null, null);
        }

        private void UpdateClock(object sender, EventArgs e)
        {
            // Saati TextBlock'a yaz
            ClockText.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
