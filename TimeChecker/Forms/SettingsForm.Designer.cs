namespace TimeChecker.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.DayTimeLabel = new System.Windows.Forms.Label();
            this.SessionTimeLabel = new System.Windows.Forms.Label();
            this.DayPLusBtn = new System.Windows.Forms.Button();
            this.DayMinusBtn = new System.Windows.Forms.Button();
            this.SessionMinusBtn = new System.Windows.Forms.Button();
            this.SessionPlusBtn = new System.Windows.Forms.Button();
            this.comboBox_types = new System.Windows.Forms.ComboBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.MaxDayPlusBtn = new System.Windows.Forms.Button();
            this.MaxDayMinusBtn = new System.Windows.Forms.Button();
            this.MaxDayLabel = new System.Windows.Forms.Label();
            this.MaxSessionPlusBtn = new System.Windows.Forms.Button();
            this.MaxSessionMinusBtn = new System.Windows.Forms.Button();
            this.MaxSessionLabel = new System.Windows.Forms.Label();
            this.ChangePassBtn = new System.Windows.Forms.Button();
            this.HidePassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DayTimeLabel
            // 
            this.DayTimeLabel.AutoSize = true;
            this.DayTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.DayTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.DayTimeLabel.Location = new System.Drawing.Point(1, 90);
            this.DayTimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DayTimeLabel.Name = "DayTimeLabel";
            this.DayTimeLabel.Size = new System.Drawing.Size(174, 46);
            this.DayTimeLabel.TabIndex = 3;
            this.DayTimeLabel.Text = "00:00:00";
            // 
            // SessionTimeLabel
            // 
            this.SessionTimeLabel.AutoSize = true;
            this.SessionTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SessionTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SessionTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.SessionTimeLabel.Location = new System.Drawing.Point(1, 132);
            this.SessionTimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SessionTimeLabel.Name = "SessionTimeLabel";
            this.SessionTimeLabel.Size = new System.Drawing.Size(174, 46);
            this.SessionTimeLabel.TabIndex = 4;
            this.SessionTimeLabel.Text = "00:00:00";
            // 
            // DayPLusBtn
            // 
            this.DayPLusBtn.BackColor = System.Drawing.Color.Transparent;
            this.DayPLusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DayPLusBtn.Enabled = false;
            this.DayPLusBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DayPLusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DayPLusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.DayPLusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayPLusBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayPLusBtn.Location = new System.Drawing.Point(197, 94);
            this.DayPLusBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DayPLusBtn.Name = "DayPLusBtn";
            this.DayPLusBtn.Size = new System.Drawing.Size(46, 42);
            this.DayPLusBtn.TabIndex = 7;
            this.DayPLusBtn.TabStop = false;
            this.DayPLusBtn.Text = "+";
            this.DayPLusBtn.UseVisualStyleBackColor = false;
            this.DayPLusBtn.Click += new System.EventHandler(this.DayPLusBtn_Click);
            // 
            // DayMinusBtn
            // 
            this.DayMinusBtn.BackColor = System.Drawing.Color.Transparent;
            this.DayMinusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DayMinusBtn.Enabled = false;
            this.DayMinusBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DayMinusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DayMinusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.DayMinusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayMinusBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayMinusBtn.Location = new System.Drawing.Point(243, 94);
            this.DayMinusBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DayMinusBtn.Name = "DayMinusBtn";
            this.DayMinusBtn.Size = new System.Drawing.Size(46, 42);
            this.DayMinusBtn.TabIndex = 8;
            this.DayMinusBtn.TabStop = false;
            this.DayMinusBtn.Text = "-";
            this.DayMinusBtn.UseVisualStyleBackColor = false;
            this.DayMinusBtn.Click += new System.EventHandler(this.DayMinusBtn_Click);
            // 
            // SessionMinusBtn
            // 
            this.SessionMinusBtn.BackColor = System.Drawing.Color.Transparent;
            this.SessionMinusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SessionMinusBtn.Enabled = false;
            this.SessionMinusBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SessionMinusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.SessionMinusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SessionMinusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SessionMinusBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SessionMinusBtn.Location = new System.Drawing.Point(243, 136);
            this.SessionMinusBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SessionMinusBtn.Name = "SessionMinusBtn";
            this.SessionMinusBtn.Size = new System.Drawing.Size(46, 42);
            this.SessionMinusBtn.TabIndex = 9;
            this.SessionMinusBtn.TabStop = false;
            this.SessionMinusBtn.Text = "-";
            this.SessionMinusBtn.UseVisualStyleBackColor = false;
            this.SessionMinusBtn.Click += new System.EventHandler(this.SessionMinusBtn_Click);
            // 
            // SessionPlusBtn
            // 
            this.SessionPlusBtn.BackColor = System.Drawing.Color.Transparent;
            this.SessionPlusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SessionPlusBtn.Enabled = false;
            this.SessionPlusBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SessionPlusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.SessionPlusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SessionPlusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SessionPlusBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SessionPlusBtn.Location = new System.Drawing.Point(197, 136);
            this.SessionPlusBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SessionPlusBtn.Name = "SessionPlusBtn";
            this.SessionPlusBtn.Size = new System.Drawing.Size(46, 42);
            this.SessionPlusBtn.TabIndex = 10;
            this.SessionPlusBtn.TabStop = false;
            this.SessionPlusBtn.Text = "+";
            this.SessionPlusBtn.UseVisualStyleBackColor = false;
            this.SessionPlusBtn.Click += new System.EventHandler(this.SessionPlusBtn_Click);
            // 
            // comboBox_types
            // 
            this.comboBox_types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_types.Enabled = false;
            this.comboBox_types.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_types.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_types.FormattingEnabled = true;
            this.comboBox_types.Location = new System.Drawing.Point(175, 189);
            this.comboBox_types.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_types.Name = "comboBox_types";
            this.comboBox_types.Size = new System.Drawing.Size(114, 32);
            this.comboBox_types.TabIndex = 11;
            this.comboBox_types.TabStop = false;
            this.comboBox_types.SelectedIndexChanged += new System.EventHandler(this.comboBox_OnChangeSelected);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.ForeColor = System.Drawing.Color.Silver;
            this.PasswordBox.Location = new System.Drawing.Point(9, 190);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordBox.MaxLength = 16;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(160, 31);
            this.PasswordBox.TabIndex = 12;
            this.PasswordBox.TabStop = false;
            this.PasswordBox.Text = "Password";
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_OnTouch);
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_OnKeyDown);
            // 
            // MaxDayPlusBtn
            // 
            this.MaxDayPlusBtn.BackColor = System.Drawing.Color.Transparent;
            this.MaxDayPlusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MaxDayPlusBtn.Enabled = false;
            this.MaxDayPlusBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaxDayPlusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.MaxDayPlusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.MaxDayPlusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxDayPlusBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxDayPlusBtn.Location = new System.Drawing.Point(197, 10);
            this.MaxDayPlusBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MaxDayPlusBtn.Name = "MaxDayPlusBtn";
            this.MaxDayPlusBtn.Size = new System.Drawing.Size(46, 42);
            this.MaxDayPlusBtn.TabIndex = 15;
            this.MaxDayPlusBtn.TabStop = false;
            this.MaxDayPlusBtn.Text = "+";
            this.MaxDayPlusBtn.UseVisualStyleBackColor = false;
            this.MaxDayPlusBtn.Click += new System.EventHandler(this.MaxDayPlusBtn_Click);
            // 
            // MaxDayMinusBtn
            // 
            this.MaxDayMinusBtn.BackColor = System.Drawing.Color.Transparent;
            this.MaxDayMinusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MaxDayMinusBtn.Enabled = false;
            this.MaxDayMinusBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaxDayMinusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.MaxDayMinusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.MaxDayMinusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxDayMinusBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxDayMinusBtn.Location = new System.Drawing.Point(243, 10);
            this.MaxDayMinusBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MaxDayMinusBtn.Name = "MaxDayMinusBtn";
            this.MaxDayMinusBtn.Size = new System.Drawing.Size(46, 42);
            this.MaxDayMinusBtn.TabIndex = 14;
            this.MaxDayMinusBtn.TabStop = false;
            this.MaxDayMinusBtn.Text = "-";
            this.MaxDayMinusBtn.UseVisualStyleBackColor = false;
            this.MaxDayMinusBtn.Click += new System.EventHandler(this.MaxDayMinusBtn_Click);
            // 
            // MaxDayLabel
            // 
            this.MaxDayLabel.AutoSize = true;
            this.MaxDayLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaxDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxDayLabel.ForeColor = System.Drawing.Color.Black;
            this.MaxDayLabel.Location = new System.Drawing.Point(1, 6);
            this.MaxDayLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MaxDayLabel.Name = "MaxDayLabel";
            this.MaxDayLabel.Size = new System.Drawing.Size(174, 46);
            this.MaxDayLabel.TabIndex = 13;
            this.MaxDayLabel.Text = "00:00:00";
            // 
            // MaxSessionPlusBtn
            // 
            this.MaxSessionPlusBtn.BackColor = System.Drawing.Color.Transparent;
            this.MaxSessionPlusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MaxSessionPlusBtn.Enabled = false;
            this.MaxSessionPlusBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaxSessionPlusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.MaxSessionPlusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.MaxSessionPlusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxSessionPlusBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxSessionPlusBtn.Location = new System.Drawing.Point(197, 52);
            this.MaxSessionPlusBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MaxSessionPlusBtn.Name = "MaxSessionPlusBtn";
            this.MaxSessionPlusBtn.Size = new System.Drawing.Size(46, 42);
            this.MaxSessionPlusBtn.TabIndex = 18;
            this.MaxSessionPlusBtn.TabStop = false;
            this.MaxSessionPlusBtn.Text = "+";
            this.MaxSessionPlusBtn.UseVisualStyleBackColor = false;
            this.MaxSessionPlusBtn.Click += new System.EventHandler(this.MaxSessionPlusBtn_Click);
            // 
            // MaxSessionMinusBtn
            // 
            this.MaxSessionMinusBtn.BackColor = System.Drawing.Color.Transparent;
            this.MaxSessionMinusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MaxSessionMinusBtn.Enabled = false;
            this.MaxSessionMinusBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaxSessionMinusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.MaxSessionMinusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.MaxSessionMinusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxSessionMinusBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxSessionMinusBtn.Location = new System.Drawing.Point(243, 52);
            this.MaxSessionMinusBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MaxSessionMinusBtn.Name = "MaxSessionMinusBtn";
            this.MaxSessionMinusBtn.Size = new System.Drawing.Size(46, 42);
            this.MaxSessionMinusBtn.TabIndex = 17;
            this.MaxSessionMinusBtn.TabStop = false;
            this.MaxSessionMinusBtn.Text = "-";
            this.MaxSessionMinusBtn.UseVisualStyleBackColor = false;
            this.MaxSessionMinusBtn.Click += new System.EventHandler(this.MaxSessionMinusBtn_Click);
            // 
            // MaxSessionLabel
            // 
            this.MaxSessionLabel.AutoSize = true;
            this.MaxSessionLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaxSessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxSessionLabel.ForeColor = System.Drawing.Color.Black;
            this.MaxSessionLabel.Location = new System.Drawing.Point(1, 48);
            this.MaxSessionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MaxSessionLabel.Name = "MaxSessionLabel";
            this.MaxSessionLabel.Size = new System.Drawing.Size(174, 46);
            this.MaxSessionLabel.TabIndex = 16;
            this.MaxSessionLabel.Text = "00:00:00";
            // 
            // ChangePassBtn
            // 
            this.ChangePassBtn.BackColor = System.Drawing.Color.Transparent;
            this.ChangePassBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChangePassBtn.Enabled = false;
            this.ChangePassBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChangePassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ChangePassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ChangePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePassBtn.Location = new System.Drawing.Point(9, 182);
            this.ChangePassBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ChangePassBtn.Name = "ChangePassBtn";
            this.ChangePassBtn.Size = new System.Drawing.Size(160, 42);
            this.ChangePassBtn.TabIndex = 19;
            this.ChangePassBtn.TabStop = false;
            this.ChangePassBtn.Text = "change Password";
            this.ChangePassBtn.UseVisualStyleBackColor = false;
            this.ChangePassBtn.Visible = false;
            this.ChangePassBtn.Click += new System.EventHandler(this.ChangePassBtn_Click);
            // 
            // HidePassBtn
            // 
            this.HidePassBtn.BackColor = System.Drawing.Color.Transparent;
            this.HidePassBtn.BackgroundImage = global::TimeChecker.Properties.Resources.open_eye;
            this.HidePassBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HidePassBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HidePassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.HidePassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.HidePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePassBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HidePassBtn.Location = new System.Drawing.Point(141, 193);
            this.HidePassBtn.Margin = new System.Windows.Forms.Padding(0);
            this.HidePassBtn.Name = "HidePassBtn";
            this.HidePassBtn.Size = new System.Drawing.Size(25, 25);
            this.HidePassBtn.TabIndex = 20;
            this.HidePassBtn.TabStop = false;
            this.HidePassBtn.UseVisualStyleBackColor = false;
            this.HidePassBtn.Click += new System.EventHandler(this.HidePassBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 230);
            this.Controls.Add(this.HidePassBtn);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.MaxSessionPlusBtn);
            this.Controls.Add(this.MaxSessionMinusBtn);
            this.Controls.Add(this.MaxSessionLabel);
            this.Controls.Add(this.MaxDayPlusBtn);
            this.Controls.Add(this.MaxDayMinusBtn);
            this.Controls.Add(this.MaxDayLabel);
            this.Controls.Add(this.comboBox_types);
            this.Controls.Add(this.SessionPlusBtn);
            this.Controls.Add(this.SessionMinusBtn);
            this.Controls.Add(this.DayMinusBtn);
            this.Controls.Add(this.DayPLusBtn);
            this.Controls.Add(this.SessionTimeLabel);
            this.Controls.Add(this.DayTimeLabel);
            this.Controls.Add(this.ChangePassBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DayTimeLabel;
        private System.Windows.Forms.Label SessionTimeLabel;
        private System.Windows.Forms.Button DayPLusBtn;
        private System.Windows.Forms.Button DayMinusBtn;
        private System.Windows.Forms.Button SessionMinusBtn;
        private System.Windows.Forms.Button SessionPlusBtn;
        private System.Windows.Forms.ComboBox comboBox_types;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button MaxDayPlusBtn;
        private System.Windows.Forms.Button MaxDayMinusBtn;
        private System.Windows.Forms.Label MaxDayLabel;
        private System.Windows.Forms.Button MaxSessionPlusBtn;
        private System.Windows.Forms.Button MaxSessionMinusBtn;
        private System.Windows.Forms.Label MaxSessionLabel;
        private System.Windows.Forms.Button ChangePassBtn;
        private System.Windows.Forms.Button HidePassBtn;
    }
}