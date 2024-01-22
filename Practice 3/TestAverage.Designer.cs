namespace Practice_3
{
    partial class TestAverage
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
            txtb_Test1 = new TextBox();
            txtb_Test2 = new TextBox();
            txtb_Test3 = new TextBox();
            label4 = new Label();
            lb_Average = new Label();
            btt_Calculate = new Button();
            btt_Clear = new Button();
            btt_Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Test 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 50);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Test 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 85);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Test 3:";
            // 
            // txtb_Test1
            // 
            txtb_Test1.Location = new Point(126, 12);
            txtb_Test1.Name = "txtb_Test1";
            txtb_Test1.Size = new Size(100, 23);
            txtb_Test1.TabIndex = 3;
            // 
            // txtb_Test2
            // 
            txtb_Test2.Location = new Point(126, 47);
            txtb_Test2.Name = "txtb_Test2";
            txtb_Test2.Size = new Size(100, 23);
            txtb_Test2.TabIndex = 4;
            // 
            // txtb_Test3
            // 
            txtb_Test3.Location = new Point(126, 82);
            txtb_Test3.Name = "txtb_Test3";
            txtb_Test3.Size = new Size(100, 23);
            txtb_Test3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 124);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 6;
            label4.Text = "TestAverage Test Score: 3:";
            // 
            // lb_Average
            // 
            lb_Average.BackColor = SystemColors.ControlLight;
            lb_Average.Location = new Point(177, 124);
            lb_Average.Name = "lb_Average";
            lb_Average.Size = new Size(123, 24);
            lb_Average.TabIndex = 7;
            lb_Average.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btt_Calculate
            // 
            btt_Calculate.Location = new Point(23, 172);
            btt_Calculate.Name = "btt_Calculate";
            btt_Calculate.Size = new Size(75, 23);
            btt_Calculate.TabIndex = 8;
            btt_Calculate.Text = "Calculate";
            btt_Calculate.UseVisualStyleBackColor = true;
            btt_Calculate.Click += btt_Calculate_Click;
            // 
            // btt_Clear
            // 
            btt_Clear.Location = new Point(126, 172);
            btt_Clear.Name = "btt_Clear";
            btt_Clear.Size = new Size(75, 23);
            btt_Clear.TabIndex = 9;
            btt_Clear.Text = "Clear";
            btt_Clear.UseVisualStyleBackColor = true;
            btt_Clear.Click += btt_Clear_Click;
            // 
            // btt_Exit
            // 
            btt_Exit.BackColor = Color.RosyBrown;
            btt_Exit.Location = new Point(228, 172);
            btt_Exit.Name = "btt_Exit";
            btt_Exit.Size = new Size(75, 23);
            btt_Exit.TabIndex = 10;
            btt_Exit.Text = "Exit";
            btt_Exit.UseVisualStyleBackColor = false;
            btt_Exit.Click += btt_Exit_Click;
            // 
            // TestAverage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 216);
            Controls.Add(btt_Exit);
            Controls.Add(btt_Clear);
            Controls.Add(btt_Calculate);
            Controls.Add(lb_Average);
            Controls.Add(label4);
            Controls.Add(txtb_Test3);
            Controls.Add(txtb_Test2);
            Controls.Add(txtb_Test1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TestAverage";
            Text = "TestAverage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtb_Test1;
        private TextBox txtb_Test2;
        private TextBox txtb_Test3;
        private Label label4;
        private Label lb_Average;
        private Button btt_Calculate;
        private Button btt_Clear;
        private Button btt_Exit;
    }
}