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
            uC_SliderHorizontal1.SliderValueChanged += OnSliderValueChangedInForm;  

        }
        private void OnSliderValueChangedInForm(object sender, EventArgs e)
        {
            tb_Form1_0.Text = uC_SliderHorizontal1.SliderValue.ToString(); // Update TextBox
        }
    }
}
