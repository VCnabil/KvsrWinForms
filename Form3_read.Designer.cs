namespace KVSRWindowsFormsAppFramework
{
    partial class Form3_read
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_01 = new System.Windows.Forms.Label();
            this.timerRead_test = new System.Windows.Forms.Timer(this.components);
            this.lbl_02 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_01
            // 
            this.lbl_01.AutoSize = true;
            this.lbl_01.Location = new System.Drawing.Point(103, 79);
            this.lbl_01.Name = "lbl_01";
            this.lbl_01.Size = new System.Drawing.Size(79, 29);
            this.lbl_01.TabIndex = 0;
            this.lbl_01.Text = "label1";
            // 
            // lbl_02
            // 
            this.lbl_02.AutoSize = true;
            this.lbl_02.Location = new System.Drawing.Point(658, 497);
            this.lbl_02.Name = "lbl_02";
            this.lbl_02.Size = new System.Drawing.Size(79, 29);
            this.lbl_02.TabIndex = 1;
            this.lbl_02.Text = "label1";
            // 
            // Form3_read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 1023);
            this.Controls.Add(this.lbl_02);
            this.Controls.Add(this.lbl_01);
            this.Name = "Form3_read";
            this.Text = "Form3_read";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_01;
        private System.Windows.Forms.Timer timerRead_test;
        private System.Windows.Forms.Label lbl_02;
    }
}