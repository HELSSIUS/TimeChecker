namespace TimeChecker.Forms
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.RepeatBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.ForeColor = System.Drawing.Color.Silver;
            this.PasswordBox.Location = new System.Drawing.Point(9, 9);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordBox.MaxLength = 16;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(180, 31);
            this.PasswordBox.TabIndex = 13;
            this.PasswordBox.TabStop = false;
            this.PasswordBox.Text = "password";
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_OnTouch);
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_OnKeyDown);
            // 
            // RepeatBox
            // 
            this.RepeatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatBox.ForeColor = System.Drawing.Color.Silver;
            this.RepeatBox.Location = new System.Drawing.Point(9, 49);
            this.RepeatBox.Margin = new System.Windows.Forms.Padding(0);
            this.RepeatBox.MaxLength = 16;
            this.RepeatBox.Name = "RepeatBox";
            this.RepeatBox.Size = new System.Drawing.Size(180, 31);
            this.RepeatBox.TabIndex = 14;
            this.RepeatBox.TabStop = false;
            this.RepeatBox.Text = "repeat password";
            this.RepeatBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RepeatBox.Enter += new System.EventHandler(this.RepeatBox_OnTouch);
            this.RepeatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RepeatBox_OnKeyDown);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 134);
            this.Controls.Add(this.RepeatBox);
            this.Controls.Add(this.PasswordBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox RepeatBox;
    }
}