namespace KVSRWindowsFormsAppFramework
{
    partial class UC_SliderHorizontal 
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mTB_Local_0 = new MetroFramework.Controls.MetroTrackBar();
            this.SuspendLayout();
            // 
            // mTB_Local_0
            // 
            this.mTB_Local_0.BackColor = System.Drawing.Color.Transparent;
            this.mTB_Local_0.Location = new System.Drawing.Point(176, 34);
            this.mTB_Local_0.Name = "mTB_Local_0";
            this.mTB_Local_0.Size = new System.Drawing.Size(344, 73);
            this.mTB_Local_0.TabIndex = 0;
            this.mTB_Local_0.Text = "metroTrackBar1";
            // 
            // UC_SliderHorizontal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mTB_Local_0);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "UC_SliderHorizontal";
            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTrackBar mTB_Local_0;
    }
}
