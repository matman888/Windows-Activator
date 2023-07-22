namespace Activator_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_Build = new System.Windows.Forms.Label();
            this.lbl_Edition = new System.Windows.Forms.Label();
            this.lbl_Activation = new System.Windows.Forms.Label();
            this.btn_Activate = new System.Windows.Forms.Button();
            this.prb = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This program will help you to activate Microsoft Windows operating system";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "OS Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Version";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Build";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Activation Status";
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(99, 108);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(35, 13);
            this.lbl_Version.TabIndex = 6;
            this.lbl_Version.Text = "label7";
            // 
            // lbl_Build
            // 
            this.lbl_Build.AutoSize = true;
            this.lbl_Build.Location = new System.Drawing.Point(99, 131);
            this.lbl_Build.Name = "lbl_Build";
            this.lbl_Build.Size = new System.Drawing.Size(35, 13);
            this.lbl_Build.TabIndex = 7;
            this.lbl_Build.Text = "label7";
            // 
            // lbl_Edition
            // 
            this.lbl_Edition.AutoSize = true;
            this.lbl_Edition.Location = new System.Drawing.Point(99, 154);
            this.lbl_Edition.Name = "lbl_Edition";
            this.lbl_Edition.Size = new System.Drawing.Size(35, 13);
            this.lbl_Edition.TabIndex = 8;
            this.lbl_Edition.Text = "label7";
            // 
            // lbl_Activation
            // 
            this.lbl_Activation.AutoSize = true;
            this.lbl_Activation.Location = new System.Drawing.Point(131, 178);
            this.lbl_Activation.Name = "lbl_Activation";
            this.lbl_Activation.Size = new System.Drawing.Size(35, 13);
            this.lbl_Activation.TabIndex = 9;
            this.lbl_Activation.Text = "label7";
            // 
            // btn_Activate
            // 
            this.btn_Activate.Location = new System.Drawing.Point(92, 295);
            this.btn_Activate.Name = "btn_Activate";
            this.btn_Activate.Size = new System.Drawing.Size(126, 23);
            this.btn_Activate.TabIndex = 10;
            this.btn_Activate.Text = "Activate Windows";
            this.btn_Activate.UseVisualStyleBackColor = true;
            this.btn_Activate.Click += new System.EventHandler(this.button1_Click);
            // 
            // prb
            // 
            this.prb.Location = new System.Drawing.Point(37, 240);
            this.prb.MarqueeAnimationSpeed = 0;
            this.prb.Name = "prb";
            this.prb.Size = new System.Drawing.Size(254, 28);
            this.prb.Step = 60;
            this.prb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Progress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 340);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prb);
            this.Controls.Add(this.btn_Activate);
            this.Controls.Add(this.lbl_Activation);
            this.Controls.Add(this.lbl_Edition);
            this.Controls.Add(this.lbl_Build);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Windows Activator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_Build;
        private System.Windows.Forms.Label lbl_Edition;
        private System.Windows.Forms.Label lbl_Activation;
        private System.Windows.Forms.Button btn_Activate;
        private System.Windows.Forms.ProgressBar prb;
        private System.Windows.Forms.Label label7;
    }
}

