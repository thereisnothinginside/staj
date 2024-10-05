using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace GlobalClicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        const uint MOUSEEVENTF_LEFTUP = 0x04;

        private Point clickPosition;
        private IKeyboardMouseEvents globalHook;
        private bool isPositionSet = false;
        private bool isListeningForClick = false;
        private CancellationTokenSource cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
            Subscribe();
        }

        private void Subscribe()
        {
            globalHook = Hook.GlobalEvents();
            globalHook.MouseDownExt += GlobalHook_MouseDownExt;
            globalHook.KeyDown += GlobalHook_KeyDown;
        }

        private void Unsubscribe()
        {
            globalHook.MouseDownExt -= GlobalHook_MouseDownExt;
            globalHook.KeyDown -= GlobalHook_KeyDown;
            globalHook.Dispose();
        }

        private void GlobalHook_MouseDownExt(object sender, MouseEventExtArgs e)
        {
            if (isListeningForClick && !isPositionSet)
            {
                if (e.Button == MouseButtons.Left)
                {
                    clickPosition = e.Location;
                    textBoxX.Text = clickPosition.X.ToString();
                    textBoxY.Text = clickPosition.Y.ToString();

                    isPositionSet = true;
                    isListeningForClick = false;
                    this.Cursor = Cursors.Default;
                    Unsubscribe();
                }
            }
        }

        private void GlobalHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                cancellationTokenSource?.Cancel();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
            isListeningForClick = true;
            isPositionSet = false;
            Subscribe();
        }

        private async void buttonBasla_Click(object sender, EventArgs e)
        {
            int numberOfClicks;
            if (int.TryParse(textBoxCount.Text, out numberOfClicks))
            {
                label1.Text = "Tıklanıyor...";
                cancellationTokenSource = new CancellationTokenSource();
                var token = cancellationTokenSource.Token;

                try
                {
                    await Task.Run(() =>
                    {
                        int MousePosx = Convert.ToInt32(textBoxX.Text);
                        int MousePosy = Convert.ToInt32(textBoxY.Text);
                       SetCursorPos(MousePosx,MousePosy);
                        for (int i = 0; i < numberOfClicks; i++)
                        {
                            token.ThrowIfCancellationRequested();


                         //  MessageBox.Show(MousePosx+ "/"+ MousePosy);
                            //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP);
                            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)clickPosition.X, (uint)clickPosition.Y, 0, 0);
                            //Thread.Sleep(2);
                            //Thread.Sleep(100);
                        }
                    }, token);
                    label1.Text = "İşlem tamamlandı";
                }
                catch (OperationCanceledException)
                {
                    label1.Text = "İşlem iptal edildi";
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }
        }
    }
}
