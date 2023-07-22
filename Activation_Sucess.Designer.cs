namespace Activator_GUI
{
    partial class Activation_Sucess
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
            this.ActivationMessage = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActivationMessage
            // 
            this.ActivationMessage.AutoSize = true;
            this.ActivationMessage.Location = new System.Drawing.Point(39, 38);
            this.ActivationMessage.Name = "ActivationMessage";
            this.ActivationMessage.Size = new System.Drawing.Size(0, 13);
            this.ActivationMessage.TabIndex = 0;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(12, 25);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(35, 13);
            this.lbl_Status.TabIndex = 1;
            this.lbl_Status.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Activation_Sucess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 122);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.ActivationMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Activation_Sucess";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Activation Status";
            this.Load += new System.EventHandler(this.Activation_Sucess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ActivationMessage;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button button1;
    }
}