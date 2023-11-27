using Kvaser.CanLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace KVSRWindowsFormsAppFramework
{
    public partial class Form3_read : Form
    {
        CanManager canManager;
        private byte[] data;
        int _png = 0x18FFBB00;

        int x = 0;
        public Form3_read()
        {
            InitializeComponent();
            canManager = new CanManager();
            canManager.ListChannels();
            canManager.OpenChannel(0);
            canManager.SetBusParams();
            canManager.GoOnBus();

            timerRead_test.Interval = 100;
            timerRead_test.Tick += TimerREADtest_Tick;

            timerRead_test.Start();
            canManager.OnMessageReceived += CanManager_OnMessageReceived;
        }

        private void CanManager_OnMessageReceived(string message)
        {
            // Check if the current thread is the UI thread
            if (this.InvokeRequired)
            {
                // If not, use Invoke to execute this method on the UI thread
                this.Invoke(new MethodInvoker(() => CanManager_OnMessageReceived(message)));
            }
            else
            {
                // Update the UI directly
                lbl_01.Text = message;
            }
        }

        private void TimerREADtest_Tick(object sender, EventArgs e)
        {
            x++;
            if (x > 65534) x = 0;

           lbl_02.Text =  x.ToString();

        }
    }

}
