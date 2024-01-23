namespace Practice_3
{
    partial class SingleStepping
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
            btt_Calc = new Button();
            btt_Clear = new Button();
            btt_Exit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lb_Display = new Label();
            txtb_R1 = new TextBox();
            txtb_R2 = new TextBox();
            txtb_R3 = new TextBox();
            SuspendLayout();
            // 
            // btt_Calc
            // 
            btt_Calc.Location = new Point(83, 267);
            btt_Calc.Name = "btt_Calc";
            btt_Calc.Size = new Size(75, 45);
            btt_Calc.TabIndex = 0;
            btt_Calc.Text = "Calculate Average";
            btt_Calc.UseVisualStyleBackColor = true;
            btt_Calc.Click += btt_Calc_Click;
            // 
            // btt_Clear
            // 
            btt_Clear.Location = new Point(179, 267);
            btt_Clear.Name = "btt_Clear";
            btt_Clear.Size = new Size(75, 45);
            btt_Clear.TabIndex = 1;
            btt_Clear.Text = "Clear";
            btt_Clear.UseVisualStyleBackColor = true;
            btt_Clear.Click += btt_Clear_Click;
            // 
            // btt_Exit
            // 
            btt_Exit.BackColor = Color.RosyBrown;
            btt_Exit.Location = new Point(275, 267);
            btt_Exit.Name = "btt_Exit";
            btt_Exit.Size = new Size(75, 45);
            btt_Exit.TabIndex = 2;
            btt_Exit.Text = "Exit";
            btt_Exit.UseVisualStyleBackColor = false;
            btt_Exit.Click += btt_Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 29);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Runner 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 75);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Runner 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 117);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Runner 3:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 187);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 6;
            label4.Text = "Average Race Time";
            // 
            // lb_Display
            // 
            lb_Display.BackColor = SystemColors.ControlDark;
            lb_Display.Location = new Point(179, 179);
            lb_Display.Name = "lb_Display";
            lb_Display.Size = new Size(130, 31);
            lb_Display.TabIndex = 7;
            lb_Display.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtb_R1
            // 
            txtb_R1.Location = new Point(179, 26);
            txtb_R1.Name = "txtb_R1";
            txtb_R1.Size = new Size(100, 23);
            txtb_R1.TabIndex = 8;
            // 
            // txtb_R2
            // 
            txtb_R2.Location = new Point(179, 72);
            txtb_R2.Name = "txtb_R2";
            txtb_R2.Size = new Size(100, 23);
            txtb_R2.TabIndex = 9;
            // 
            // txtb_R3
            // 
            txtb_R3.Location = new Point(179, 117);
            txtb_R3.Name = "txtb_R3";
            txtb_R3.Size = new Size(100, 23);
            txtb_R3.TabIndex = 10;
            // 
            // SingleStepping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 333);
            Controls.Add(txtb_R3);
            Controls.Add(txtb_R2);
            Controls.Add(txtb_R1);
            Controls.Add(lb_Display);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btt_Exit);
            Controls.Add(btt_Clear);
            Controls.Add(btt_Calc);
            Name = "SingleStepping";
            Text = "SingleStepping";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btt_Calc;
        private Button btt_Clear;
        private Button btt_Exit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lb_Display;
        private TextBox txtb_R1;
        private TextBox txtb_R2;
        private TextBox txtb_R3;
    }
}