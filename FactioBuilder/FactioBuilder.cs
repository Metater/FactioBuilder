using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetaMitStandard;

namespace FactioBuilder
{
    public partial class FactioBuilder : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private static Timer timer = new Timer();
        private Queue<string> queuedMessages = new Queue<string>();
        private int messageLine = 0;

        private MetaMitClient client;

        public FactioBuilder()
        {
            InitializeComponent();
        }

        private void FactioBuilder_Load(object sender, EventArgs e)
        {
            client = new MetaMitClient();
            client.Connected += OnConnected;
            client.DataSent += OnDataSent;
            client.Disconnected += OnDisconnected;
            client.Connect(Constants.Ip, Constants.Port);
            SetTimer();
        }

        private void OnConnected(object sender, MetaMitStandard.Client.ConnectedEventArgs e)
        {

        }

        private void OnDataSent(object sender, MetaMitStandard.Client.DataSentEventArgs e)
        {

        }

        private void OnDisconnected(object sender, MetaMitStandard.Client.DisconnectedEventArgs e)
        {

        }

        private void FactioBuilder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SetTimer()
        {
            timer.Interval = 50;
            timer.Start();
            timer.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            SendMessage("Hello?");
        }

        private void SendMessage(string message)
        {
            queuedMessages.Enqueue($"{messageLine}: {message}");
            messageLine++;
            int visibleItems = MessagesListBox.ClientSize.Height / MessagesListBox.ItemHeight;
            int topIndex = Math.Max(MessagesListBox.Items.Count - visibleItems + 1, 0);
            if (MessagesListBox.Capture) return;
            while (queuedMessages.Count != 0)
            {
                MessagesListBox.Items.Add(queuedMessages.Dequeue());
            }
            MessagesListBox.TopIndex = topIndex;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
