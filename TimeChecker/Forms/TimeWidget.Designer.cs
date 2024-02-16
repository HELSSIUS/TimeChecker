namespace TimeChecker
{
    partial class TimeWidget
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeWidget));
            this.SessionTimeLabel = new System.Windows.Forms.Label();
            this.DayTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SessionTimeLabel
            // 
            this.SessionTimeLabel.AutoSize = true;
            this.SessionTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SessionTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SessionTimeLabel.ForeColor = System.Drawing.Color.White;
            this.SessionTimeLabel.Location = new System.Drawing.Point(9, 51);
            this.SessionTimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SessionTimeLabel.Name = "SessionTimeLabel";
            this.SessionTimeLabel.Size = new System.Drawing.Size(174, 46);
            this.SessionTimeLabel.TabIndex = 1;
            this.SessionTimeLabel.Text = "00:00:00";
            this.SessionTimeLabel.DoubleClick += new System.EventHandler(this.TimeLabel_OnDoubleClick);
            this.SessionTimeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.SessionTimeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.SessionTimeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Event);
            // 
            // DayTimeLabel
            // 
            this.DayTimeLabel.AutoSize = true;
            this.DayTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.DayTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayTimeLabel.ForeColor = System.Drawing.Color.White;
            this.DayTimeLabel.Location = new System.Drawing.Point(9, -4);
            this.DayTimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DayTimeLabel.Name = "DayTimeLabel";
            this.DayTimeLabel.Size = new System.Drawing.Size(174, 46);
            this.DayTimeLabel.TabIndex = 2;
            this.DayTimeLabel.Text = "00:00:00";
            this.DayTimeLabel.DoubleClick += new System.EventHandler(this.TimeLabel_OnDoubleClick);
            this.DayTimeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.DayTimeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.DayTimeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Event);
            // 
            // TimeWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(179, 92);
            this.Controls.Add(this.DayTimeLabel);
            this.Controls.Add(this.SessionTimeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeWidget";
            this.Opacity = 0.2D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TimeWidget";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SessionTimeLabel;
        private System.Windows.Forms.Label DayTimeLabel;
    }
}

