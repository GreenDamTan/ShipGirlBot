namespace ShipGirlBot.GreenDam
{
    partial class GreenDamMessage
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
            this.GreenDam_Messages = new System.Windows.Forms.Label();
            this.GreenDamMessage_close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreenDam_Messages
            // 
            this.GreenDam_Messages.AutoSize = true;
            this.GreenDam_Messages.Location = new System.Drawing.Point(12, 63);
            this.GreenDam_Messages.Name = "GreenDam_Messages";
            this.GreenDam_Messages.Size = new System.Drawing.Size(41, 12);
            this.GreenDam_Messages.TabIndex = 0;
            this.GreenDam_Messages.Text = "label1";
            // 
            // GreenDamMessage_close_button
            // 
            this.GreenDamMessage_close_button.Location = new System.Drawing.Point(9, 7);
            this.GreenDamMessage_close_button.Name = "GreenDamMessage_close_button";
            this.GreenDamMessage_close_button.Size = new System.Drawing.Size(257, 38);
            this.GreenDamMessage_close_button.TabIndex = 1;
            this.GreenDamMessage_close_button.Text = "关闭窗口哒哟";
            this.GreenDamMessage_close_button.UseVisualStyleBackColor = true;
            this.GreenDamMessage_close_button.Click += new System.EventHandler(this.GreenDamMessage_close_button_Click);
            // 
            // GreenDamMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(275, 107);
            this.Controls.Add(this.GreenDamMessage_close_button);
            this.Controls.Add(this.GreenDam_Messages);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.Name = "GreenDamMessage";
            this.ShowInTaskbar = false;
            this.Text = "GreenDamMessage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GreenDamMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GreenDam_Messages;
        private System.Windows.Forms.Button GreenDamMessage_close_button;
    }
}