namespace KVSRWindowsFormsAppFramework
{
    partial class Form1
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
            this.uC_SliderHorizontal1 = new KVSRWindowsFormsAppFramework.UC_SliderHorizontal();
            this.tb_Form1_0 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uC_SliderHorizontal1
            // 
            this.uC_SliderHorizontal1.Location = new System.Drawing.Point(322, 216);
            this.uC_SliderHorizontal1.MaximumSize = new System.Drawing.Size(400, 200);
            this.uC_SliderHorizontal1.MinimumSize = new System.Drawing.Size(400, 200);
            this.uC_SliderHorizontal1.Name = "uC_SliderHorizontal1";
            this.uC_SliderHorizontal1.Size = new System.Drawing.Size(400, 200);
            this.uC_SliderHorizontal1.TabIndex = 0;
            // 
            // tb_Form1_0
            // 
            this.tb_Form1_0.Location = new System.Drawing.Point(945, 241);
            this.tb_Form1_0.Name = "tb_Form1_0";
            this.tb_Form1_0.Size = new System.Drawing.Size(266, 35);
            this.tb_Form1_0.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1232);
            this.Controls.Add(this.tb_Form1_0);
            this.Controls.Add(this.uC_SliderHorizontal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_SliderHorizontal uC_SliderHorizontal1;
        private System.Windows.Forms.TextBox tb_Form1_0;
    }
}

