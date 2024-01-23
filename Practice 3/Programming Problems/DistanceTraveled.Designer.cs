namespace Practice_3.Programming_Problems
{
    partial class DistanceTraveled
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
            this.lb_Display = new System.Windows.Forms.Label();
            this.btt_Calculate = new System.Windows.Forms.Button();
            this.btt_5hours = new System.Windows.Forms.Button();
            this.btt_8hours = new System.Windows.Forms.Button();
            this.btt_12hours = new System.Windows.Forms.Button();
            this.txtb_Mph = new System.Windows.Forms.TextBox();
            this.txtb_Time = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miles per Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time Driven";
            // 
            // lb_Display
            // 
            this.lb_Display.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Display.Location = new System.Drawing.Point(66, 211);
            this.lb_Display.Name = "lb_Display";
            this.lb_Display.Size = new System.Drawing.Size(245, 38);
            this.lb_Display.TabIndex = 2;
            this.lb_Display.Text = "Yassss Slaayy";
            this.lb_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btt_Calculate
            // 
            this.btt_Calculate.Location = new System.Drawing.Point(148, 119);
            this.btt_Calculate.Name = "btt_Calculate";
            this.btt_Calculate.Size = new System.Drawing.Size(100, 29);
            this.btt_Calculate.TabIndex = 3;
            this.btt_Calculate.Text = "Calculate";
            this.btt_Calculate.UseVisualStyleBackColor = true;
            this.btt_Calculate.Click += new System.EventHandler(this.btt_Calculate_Click);
            // 
            // btt_5hours
            // 
            this.btt_5hours.Location = new System.Drawing.Point(47, 163);
            this.btt_5hours.Name = "btt_5hours";
            this.btt_5hours.Size = new System.Drawing.Size(98, 23);
            this.btt_5hours.TabIndex = 4;
            this.btt_5hours.Text = "5 Hours";
            this.btt_5hours.UseVisualStyleBackColor = true;
            this.btt_5hours.Click += new System.EventHandler(this.btt_5hours_Click);
            // 
            // btt_8hours
            // 
            this.btt_8hours.Location = new System.Drawing.Point(148, 163);
            this.btt_8hours.Name = "btt_8hours";
            this.btt_8hours.Size = new System.Drawing.Size(98, 23);
            this.btt_8hours.TabIndex = 5;
            this.btt_8hours.Text = "8 Hours";
            this.btt_8hours.UseVisualStyleBackColor = true;
            this.btt_8hours.Click += new System.EventHandler(this.btt_8hours_Click);
            // 
            // btt_12hours
            // 
            this.btt_12hours.Location = new System.Drawing.Point(249, 163);
            this.btt_12hours.Name = "btt_12hours";
            this.btt_12hours.Size = new System.Drawing.Size(98, 23);
            this.btt_12hours.TabIndex = 6;
            this.btt_12hours.Text = "12 Hours";
            this.btt_12hours.UseVisualStyleBackColor = true;
            this.btt_12hours.Click += new System.EventHandler(this.btt_12hours_Click);
            // 
            // txtb_Mph
            // 
            this.txtb_Mph.Location = new System.Drawing.Point(148, 36);
            this.txtb_Mph.Name = "txtb_Mph";
            this.txtb_Mph.Size = new System.Drawing.Size(100, 26);
            this.txtb_Mph.TabIndex = 7;
            // 
            // txtb_Time
            // 
            this.txtb_Time.Location = new System.Drawing.Point(148, 78);
            this.txtb_Time.Name = "txtb_Time";
            this.txtb_Time.Size = new System.Drawing.Size(100, 26);
            this.txtb_Time.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "hours";
            // 
            // DistanceTraveled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 276);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb_Time);
            this.Controls.Add(this.txtb_Mph);
            this.Controls.Add(this.btt_12hours);
            this.Controls.Add(this.btt_8hours);
            this.Controls.Add(this.btt_5hours);
            this.Controls.Add(this.btt_Calculate);
            this.Controls.Add(this.lb_Display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DistanceTraveled";
            this.Text = "DistanceTraveled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lb_Display;
        private Button btt_Calculate;
        private Button btt_5hours;
        private Button btt_8hours;
        private Button btt_12hours;
        private TextBox txtb_Mph;
        private TextBox txtb_Time;
        private Label label4;
    }
}