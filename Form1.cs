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
        CanManager canManager;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            canManager = new CanManager();
            canManager.ListChannels();
            canManager.OpenChannel(0);
            canManager.SetBusParams();
            canManager.GoOnBus();

            this.button1_send0.Click += Button1_send0_Click;

        }

        private void Button1_send0_Click(object sender, EventArgs e)
        {
            this.uC_FullPGN1.Generate();
            string outstr = "";
            int pgnid=this.uC_FullPGN1.Get_LocalPGN();
          //  MessageBox.Show(pgnid.ToString());
            outstr ="0x"+ pgnid.ToString("X")+" ||  ";
            byte[] outarra = this.uC_FullPGN1.Get_Bytes();

            for (int i = outarra.Length-1; i >=0; i--) {
                outstr += outarra[i].ToString() + "  :  ";
            }
            this.label1_output.Text = "" + outstr;
            canManager.SendMessage(pgnid, outarra);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            canManager.GoOffBus();
            canManager.CloseChannel();
        }
    }
}


//         InitializeComponent();
//uC_SliderHorizontal1.SliderValueChanged += OnSliderValueChangedInForm;  

//private void OnSliderValueChangedInForm(object sender, EventArgs e)
//{
//    tb_Form1_0.Text = uC_SliderHorizontal1.SliderValue.ToString(); // Update TextBox
//}