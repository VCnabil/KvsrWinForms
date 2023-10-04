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
    public partial class UC_FullPGN : UserControl
    {
        private byte[] data;
        private UC_Byte[] uC_Bytes;
        private Label[] labels;
        int _localPGN_INT = 0;
        public UC_FullPGN()
        {
            InitializeComponent();
            data = new byte[8];
            uC_Bytes = new UC_Byte[] { uC_Byte0, uC_Byte1, uC_Byte2, uC_Byte3, uC_Byte4, uC_Byte5, uC_Byte6, uC_Byte7 };
            labels = new Label[] { label0, label1, label2, label3, label4, label5, label6, label7 };

            for (int i = 0; i < 8; i++)
            {
                uC_Bytes[i].SetGroupBoxText($"B-{i}");
                labels[i].Text = "0";
            }

            this.button1_Generate.Click += new System.EventHandler(this.ButtonGenerateCliked);


            for (int i = 0; i < 8; i++)
            {
                int index = i;  // Capture loop variable
                uC_Bytes[i].ValueChanged += (value) => UpdateLabel(index, value);
            }
        }

        public int Get_LocalPGN() { 
        return _localPGN_INT;
        }
        public UC_Byte[] Get_Bytes()
        {
            return uC_Bytes;
        }
        private void ButtonGenerateCliked(object sender, EventArgs e)
        {

            for (int i = 0; i < 8; i++)
            {
                data[i] = (byte)uC_Bytes[i].GetByte_Value();
                //labels[i].Text = uC_Bytes[i].GetByte_Value().ToString();
               // labels[i].Text = data[i].ToString();
            }
            _localPGN_INT = HexStringToInt(textBox1_PGNentry.Text);
            label8.Text = _localPGN_INT.ToString();


        }
        private void UpdateLabel(int index, int value)
        {
            labels[index].Text = value.ToString();
        }
        private int HexStringToInt(string hexString)
        {
            int intValue;
            if (int.TryParse(hexString, System.Globalization.NumberStyles.HexNumber, null, out intValue))
            {
                return intValue;
            }
            else
            {
                // Handle the conversion failure as you see fit
                return -1;
            }
        }
    }
}
