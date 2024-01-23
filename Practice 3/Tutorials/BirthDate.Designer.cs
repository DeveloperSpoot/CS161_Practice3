namespace Practice_3
{
    partial class BirthDate
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtb_day = new TextBox();
            txtb_Month = new TextBox();
            txtb_nDay = new TextBox();
            txtb_Year = new TextBox();
            dateDisplay = new Label();
            btt_ShowDate = new Button();
            btt_Clear = new Button();
            btt_Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 26);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter the day of the week:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 56);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter the name of the month:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 86);
            label3.Name = "label3";
            label3.Size = new Size(196, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter the numeric day of the month";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 116);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "Enter the year:";
            // 
            // txtb_day
            // 
            txtb_day.Location = new Point(225, 23);
            txtb_day.Name = "txtb_day";
            txtb_day.Size = new Size(100, 23);
            txtb_day.TabIndex = 4;
            // 
            // txtb_Month
            // 
            txtb_Month.Location = new Point(225, 56);
            txtb_Month.Name = "txtb_Month";
            txtb_Month.Size = new Size(100, 23);
            txtb_Month.TabIndex = 5;
            // 
            // txtb_nDay
            // 
            txtb_nDay.Location = new Point(225, 85);
            txtb_nDay.Name = "txtb_nDay";
            txtb_nDay.Size = new Size(100, 23);
            txtb_nDay.TabIndex = 6;
            // 
            // txtb_Year
            // 
            txtb_Year.Location = new Point(225, 116);
            txtb_Year.Name = "txtb_Year";
            txtb_Year.Size = new Size(100, 23);
            txtb_Year.TabIndex = 7;
            // 
            // dateDisplay
            // 
            dateDisplay.BackColor = SystemColors.ButtonHighlight;
            dateDisplay.BorderStyle = BorderStyle.FixedSingle;
            dateDisplay.Location = new Point(23, 159);
            dateDisplay.Name = "dateDisplay";
            dateDisplay.Size = new Size(302, 23);
            dateDisplay.TabIndex = 8;
            dateDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btt_ShowDate
            // 
            btt_ShowDate.Location = new Point(47, 196);
            btt_ShowDate.Name = "btt_ShowDate";
            btt_ShowDate.Size = new Size(75, 23);
            btt_ShowDate.TabIndex = 9;
            btt_ShowDate.Text = "Show Date";
            btt_ShowDate.UseVisualStyleBackColor = true;
            btt_ShowDate.Click += btt_ShowDate_Click;
            // 
            // btt_Clear
            // 
            btt_Clear.Location = new Point(141, 196);
            btt_Clear.Name = "btt_Clear";
            btt_Clear.Size = new Size(75, 23);
            btt_Clear.TabIndex = 10;
            btt_Clear.Text = "Clear";
            btt_Clear.UseVisualStyleBackColor = true;
            btt_Clear.Click += btt_Clear_Click;
            // 
            // btt_Exit
            // 
            btt_Exit.BackColor = Color.RosyBrown;
            btt_Exit.Location = new Point(235, 196);
            btt_Exit.Name = "btt_Exit";
            btt_Exit.Size = new Size(75, 23);
            btt_Exit.TabIndex = 11;
            btt_Exit.Text = "Exit";
            btt_Exit.UseVisualStyleBackColor = false;
            btt_Exit.Click += btt_Exit_Click;
            // 
            // BirthDate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 240);
            Controls.Add(btt_Exit);
            Controls.Add(btt_Clear);
            Controls.Add(btt_ShowDate);
            Controls.Add(dateDisplay);
            Controls.Add(txtb_Year);
            Controls.Add(txtb_nDay);
            Controls.Add(txtb_Month);
            Controls.Add(txtb_day);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BirthDate";
            Text = "BirthDate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtb_day;
        private TextBox txtb_Month;
        private TextBox txtb_nDay;
        private TextBox txtb_Year;
        private Label dateDisplay;
        private Button btt_ShowDate;
        private Button btt_Clear;
        private Button btt_Exit;
    }
}