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

namespace KVSRWindowsFormsAppFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Canlib.canStatus R;
            int V;

            textBox1.Clear();
            textBox1.Text = "DEMO VS2019\r\n";

            Canlib.canInitializeLibrary();

            V = Canlib.canGetVersionEx(Canlib.canVERSION_CANLIB32_PRODVER32);
            int V1 = (V & 0xFF0000) >> 16;
            int V2 = (V & 0xFF00) >> 8;
            textBox1.Text += string.Format("Found CANlib version {0}.{1}\r\n", V1, V2);

            R = Canlib.canGetNumberOfChannels(out int NOC);

            textBox1.Text += string.Format("Found {0} channels\r\n", NOC);
            textBox1.Text += "----------------------------------------\r\n";
        }
    }
}
