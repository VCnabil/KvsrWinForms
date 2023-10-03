using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
namespace KVSRWindowsFormsAppFramework
{
    public partial class UC_SliderHorizontal : MetroUserControl
    {
        public event EventHandler SliderValueChanged;
        public UC_SliderHorizontal()
        {
            InitializeComponent();
            mTB_Local_0.ValueChanged += OnSliderValueChanged;
        }
        private void OnSliderValueChanged(object sender, EventArgs e)
        {
            SliderValueChanged?.Invoke(sender, e); 
        }
        public int SliderValue
        {
            get { return mTB_Local_0.Value; }
        }
    }
}
