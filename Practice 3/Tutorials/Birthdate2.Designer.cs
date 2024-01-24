namespace Practice_3.Tutorials
{
    partial class Birthdate2
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
            btt_Exit = new Button();
            btt_Clear = new Button();
            btt_ShowDate = new Button();
            dateDisplay = new Label();
            txtb_Year = new TextBox();
            txtb_nDay = new TextBox();
            txtb_Month = new TextBox();
            txtb_day = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btt_Exit
            // 
            btt_Exit.BackColor = Color.RosyBrown;
            btt_Exit.Location = new Point(232, 190);
            btt_Exit.Name = "btt_Exit";
            btt_Exit.Size = new Size(75, 23);
            btt_Exit.TabIndex = 23;
            btt_Exit.Text = "Exit";
            btt_Exit.UseVisualStyleBackColor = false;
            // 
            // btt_Clear
            // 
            btt_Clear.Location = new Point(138, 190);
            btt_Clear.Name = "btt_Clear";
            btt_Clear.Size = new Size(75, 23);
            btt_Clear.TabIndex = 22;
            btt_Clear.Text = "Clear";
            btt_Clear.UseVisualStyleBackColor = true;
            // 
            // btt_ShowDate
            // 
            btt_ShowDate.Location = new Point(44, 190);
            btt_ShowDate.Name = "btt_ShowDate";
            btt_ShowDate.Size = new Size(75, 23);
            btt_ShowDate.TabIndex = 21;
            btt_ShowDate.Text = "Show Date";
            btt_ShowDate.UseVisualStyleBackColor = true;
            btt_ShowDate.Click += btt_ShowDate_Click;
            // 
            // dateDisplay
            // 
            dateDisplay.BackColor = SystemColors.ButtonHighlight;
            dateDisplay.BorderStyle = BorderStyle.FixedSingle;
            dateDisplay.Location = new Point(20, 153);
            dateDisplay.Name = "dateDisplay";
            dateDisplay.Size = new Size(302, 23);
            dateDisplay.TabIndex = 20;
            dateDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtb_Year
            // 
            txtb_Year.Location = new Point(222, 110);
            txtb_Year.Name = "txtb_Year";
            txtb_Year.Size = new Size(100, 23);
            txtb_Year.TabIndex = 19;
            // 
            // txtb_nDay
            // 
            txtb_nDay.Location = new Point(222, 79);
            txtb_nDay.Name = "txtb_nDay";
            txtb_nDay.Size = new Size(100, 23);
            txtb_nDay.TabIndex = 18;
            // 
            // txtb_Month
            // 
            txtb_Month.Location = new Point(222, 50);
            txtb_Month.Name = "txtb_Month";
            txtb_Month.Size = new Size(100, 23);
            txtb_Month.TabIndex = 17;
            // 
            // txtb_day
            // 
            txtb_day.Location = new Point(222, 17);
            txtb_day.Name = "txtb_day";
            txtb_day.Size = new Size(100, 23);
            txtb_day.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 110);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 15;
            label4.Text = "Enter the year:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 80);
            label3.Name = "label3";
            label3.Size = new Size(196, 15);
            label3.TabIndex = 14;
            label3.Text = "Enter the numeric day of the month";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 50);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 13;
            label2.Text = "Enter the name of the month:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 20);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 12;
            label1.Text = "Enter the day of the week:";
            // 
            // Birthdate2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 240);
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
            Name = "Birthdate2";
            Text = "Birthdate2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btt_Exit;
        private Button btt_Clear;
        private Button btt_ShowDate;
        private Label dateDisplay;
        private TextBox txtb_Year;
        private TextBox txtb_nDay;
        private TextBox txtb_Month;
        private TextBox txtb_day;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}