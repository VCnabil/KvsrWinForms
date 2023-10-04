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
    public partial class UC_Byte : UserControl
    {
        private int Finalvalue = 0;

        public UC_Byte()
        {
            InitializeComponent();
            this.metroRadioButton1_bin.CheckedChanged += new System.EventHandler(this.radioButtonBin_CheckedChanged);
            this.metroRadioButton2_Hex.CheckedChanged += new System.EventHandler(this.radioButtonHex_CheckedChanged);
            this.metroRadioButton3_Dec.CheckedChanged += new System.EventHandler(this.radioButtonDec_CheckedChanged);
            this.metroRadioButton4_Sld.CheckedChanged += new System.EventHandler(this.radioButtonSLD_CheckedChanged);
            this.metroCheckBox_0.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.metroCheckBox_1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.metroCheckBox_2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.metroCheckBox_3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.metroCheckBox_4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.metroCheckBox_5.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.metroCheckBox_6.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.metroCheckBox_7.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.textBox_HEX.TextChanged += new System.EventHandler(this.textBoxHex_TextChanged);
            this.textBox_Dec.TextChanged += new System.EventHandler(this.textBoxDec_TextChanged);
            this.metroTrackBar1.ValueChanged += new System.EventHandler(this.slider_ValueChanged);
            TogglePanels(panel_Bin);
            this.metroRadioButton1_bin.Checked = true;
        }
        public event Action<int> ValueChanged;
        public void SetGroupBoxText(string newText)
        {
            groupBox1.Text = newText;
        }

        public int GetByte_Value()
        {
            return this.Finalvalue;
        }
        private void TogglePanels(Panel activePanel)
        {
            panel_Bin.Visible = false;
            panel_Hex.Visible = false;
            panel_Dec.Visible = false;
            panel_Slider.Visible = false;

            activePanel.Visible = true;
        }
        private void radioButtonBin_CheckedChanged(object sender, EventArgs e)
        {
            TogglePanels(panel_Bin);
        }
        private void radioButtonHex_CheckedChanged(object sender, EventArgs e)
        {
            TogglePanels(panel_Hex);
        }

        private void radioButtonDec_CheckedChanged(object sender, EventArgs e)
        {
            TogglePanels(panel_Dec);
        }

        private void radioButtonSLD_CheckedChanged(object sender, EventArgs e)
        {
            TogglePanels(panel_Slider);
        }


        private void checkBox_CheckedChanged(object sender, EventArgs e)
        { 
            Finalvalue = (metroCheckBox_0.Checked ? 1 : 0) + (metroCheckBox_1.Checked ? 2 : 0) + (metroCheckBox_2.Checked ? 4 : 0) + (metroCheckBox_3.Checked ? 8 : 0) + (metroCheckBox_4.Checked ? 16 : 0) + (metroCheckBox_5.Checked ? 32 : 0) + (metroCheckBox_6.Checked ? 64 : 0) + (metroCheckBox_7.Checked ? 128 : 0);
            UpdateValue();
        }
        private void textBoxHex_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_HEX.Text, System.Globalization.NumberStyles.HexNumber, null, out int hexValue))
            {
                Finalvalue = hexValue;
                UpdateValue();
            }
        }
        private void textBoxDec_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_Dec.Text, out int decValue))
            {
                Finalvalue = decValue;
                UpdateValue();
            }
        }
        private void slider_ValueChanged(object sender, EventArgs e)
        {
            Finalvalue = metroTrackBar1.Value;
            UpdateValue();
        }
        private void UpdateValue()
        {
            // Update the value wherever needed
            //label1_FinalValue.Text = "Value: " + Finalvalue.ToString();
            label1_FinalValue.Text = $"Value: {Finalvalue} (0x{Finalvalue:X})";
            ValueChanged?.Invoke(Finalvalue);
        }
    }
}
