namespace Practice_3.Programming_Problems
{
    partial class IngredientAdjuster
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
            txtb_CookiesAmount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lb_Sugar = new Label();
            lb_Butter = new Label();
            lb_Flour = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 21);
            label1.TabIndex = 0;
            label1.Text = "Number of Cookies Wanted:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtb_CookiesAmount
            // 
            txtb_CookiesAmount.Location = new Point(242, 9);
            txtb_CookiesAmount.Name = "txtb_CookiesAmount";
            txtb_CookiesAmount.Size = new Size(100, 23);
            txtb_CookiesAmount.TabIndex = 1;
            txtb_CookiesAmount.TextChanged += txtb_CookiesAmount_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 55);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Cups of Sugar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 102);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 3;
            label3.Text = "Cups of Butter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 143);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 4;
            label4.Text = "Cups of Flour";
            // 
            // lb_Sugar
            // 
            lb_Sugar.BackColor = SystemColors.ControlLight;
            lb_Sugar.BorderStyle = BorderStyle.FixedSingle;
            lb_Sugar.Location = new Point(182, 55);
            lb_Sugar.Name = "lb_Sugar";
            lb_Sugar.Size = new Size(100, 23);
            lb_Sugar.TabIndex = 5;
            lb_Sugar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_Butter
            // 
            lb_Butter.BackColor = SystemColors.ControlLight;
            lb_Butter.BorderStyle = BorderStyle.FixedSingle;
            lb_Butter.Location = new Point(182, 102);
            lb_Butter.Name = "lb_Butter";
            lb_Butter.Size = new Size(100, 23);
            lb_Butter.TabIndex = 6;
            lb_Butter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_Flour
            // 
            lb_Flour.BackColor = SystemColors.ControlLight;
            lb_Flour.BorderStyle = BorderStyle.FixedSingle;
            lb_Flour.Location = new Point(182, 143);
            lb_Flour.Name = "lb_Flour";
            lb_Flour.Size = new Size(100, 23);
            lb_Flour.TabIndex = 7;
            lb_Flour.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IngredientAdjuster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 187);
            Controls.Add(lb_Flour);
            Controls.Add(lb_Butter);
            Controls.Add(lb_Sugar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtb_CookiesAmount);
            Controls.Add(label1);
            Name = "IngredientAdjuster";
            Text = "IngredientAdjuster";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtb_CookiesAmount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lb_Sugar;
        private Label lb_Butter;
        private Label lb_Flour;
    }
}