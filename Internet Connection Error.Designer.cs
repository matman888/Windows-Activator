namespace Activator_GUI
{
    partial class Internet_Connection_Error
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
            this.butn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "You do not have access to the Internet. Please check your Internet Connection.\r\n " +
    "If you cannot access the Internet contact your Internet Service Provider to give" +
    " you assistance\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // butn_close
            // 
            this.butn_close.Location = new System.Drawing.Point(244, 100);
            this.butn_close.Name = "butn_close";
            this.butn_close.Size = new System.Drawing.Size(75, 23);
            this.butn_close.TabIndex = 2;
            this.butn_close.Text = "OK";
            this.butn_close.UseVisualStyleBackColor = true;
            this.butn_close.Click += new System.EventHandler(this.butn_close_Click);
            // 
            // Internet_Connection_Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 137);
            this.Controls.Add(this.butn_close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Internet_Connection_Error";
            this.ShowIcon = false;
            this.Text = "The Internet Connection is missing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Internet_Connection_Error_FormClosed);
            this.Load += new System.EventHandler(this.Internet_Connection_Error_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butn_close;
    }
}