using System;

namespace KVSRWindowsFormsAppFramework
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1_send0;
        private System.Windows.Forms.Label label1_output;
        private UC_FullPGN uC_FullPGN1;
        private System.Windows.Forms.Button button_clearpv;
        private System.Windows.Forms.Timer timer_autosend01;

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
            this.button1_send0 = new System.Windows.Forms.Button();
            this.label1_output = new System.Windows.Forms.Label();
            this.uC_FullPGN1 = new KVSRWindowsFormsAppFramework.UC_FullPGN();
            this.button_clearpv = new System.Windows.Forms.Button();
            this.timer_autosend01 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1_send0
            // 
            this.button1_send0.Location = new System.Drawing.Point(459, 408);
            this.button1_send0.Name = "button1_send0";
            this.button1_send0.Size = new System.Drawing.Size(121, 72);
            this.button1_send0.TabIndex = 1;
            this.button1_send0.Text = "send";
            this.button1_send0.UseVisualStyleBackColor = true;
            // 
            // label1_output
            // 
            this.label1_output.AutoSize = true;
            this.label1_output.Location = new System.Drawing.Point(454, 359);
            this.label1_output.Name = "label1_output";
            this.label1_output.Size = new System.Drawing.Size(561, 29);
            this.label1_output.TabIndex = 2;
            this.label1_output.Text = "PGN 0x18FF8C02 |  00  FF  12   44   00   AA   77   88";
            // 
            // uC_FullPGN1
            // 
            this.uC_FullPGN1.Location = new System.Drawing.Point(0, 12);
            this.uC_FullPGN1.Name = "uC_FullPGN1";
            this.uC_FullPGN1.Size = new System.Drawing.Size(3900, 340);
            this.uC_FullPGN1.TabIndex = 3;
            // 
            // button_clearpv
            // 
            this.button_clearpv.Location = new System.Drawing.Point(810, 420);
            this.button_clearpv.Name = "button_clearpv";
            this.button_clearpv.Size = new System.Drawing.Size(182, 59);
            this.button_clearpv.TabIndex = 4;
            this.button_clearpv.Text = "clearpv";
            this.button_clearpv.UseVisualStyleBackColor = true;
            this.button_clearpv.Click += new System.EventHandler(this.button_clearpv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3912, 1121);
            this.Controls.Add(this.button_clearpv);
            this.Controls.Add(this.uC_FullPGN1);
            this.Controls.Add(this.label1_output);
            this.Controls.Add(this.button1_send0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // timer
            //
            this.timer_autosend01.Tick += new System.EventHandler(this.Timer_Tick);
        }

        #endregion
       

    }
}

