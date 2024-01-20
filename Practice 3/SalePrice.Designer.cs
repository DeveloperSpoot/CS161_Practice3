namespace Practice_3
{
    partial class SalePrice
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
            txtb_Price = new TextBox();
            txtb_Precent = new TextBox();
            label3 = new Label();
            lb_SalePrice = new Label();
            btt_Calculate = new Button();
            btt_Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter  the item's original price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 59);
            label2.Name = "label2";
            label2.Size = new Size(168, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter the discount precentage:";
            // 
            // txtb_Price
            // 
            txtb_Price.Location = new Point(194, 23);
            txtb_Price.Name = "txtb_Price";
            txtb_Price.Size = new Size(100, 23);
            txtb_Price.TabIndex = 2;
            // 
            // txtb_Precent
            // 
            txtb_Precent.Location = new Point(194, 56);
            txtb_Precent.Name = "txtb_Precent";
            txtb_Precent.Size = new Size(100, 23);
            txtb_Precent.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 94);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Sale Price:";
            // 
            // lb_SalePrice
            // 
            lb_SalePrice.BackColor = SystemColors.ControlLight;
            lb_SalePrice.BorderStyle = BorderStyle.FixedSingle;
            lb_SalePrice.Location = new Point(194, 90);
            lb_SalePrice.Name = "lb_SalePrice";
            lb_SalePrice.Size = new Size(100, 23);
            lb_SalePrice.TabIndex = 5;
            lb_SalePrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btt_Calculate
            // 
            btt_Calculate.Location = new Point(65, 140);
            btt_Calculate.Name = "btt_Calculate";
            btt_Calculate.Size = new Size(75, 23);
            btt_Calculate.TabIndex = 6;
            btt_Calculate.Text = "Calculate";
            btt_Calculate.UseVisualStyleBackColor = true;
            btt_Calculate.Click += btt_Calculate_Click;
            // 
            // btt_Exit
            // 
            btt_Exit.BackColor = Color.RosyBrown;
            btt_Exit.Location = new Point(172, 140);
            btt_Exit.Name = "btt_Exit";
            btt_Exit.Size = new Size(75, 23);
            btt_Exit.TabIndex = 7;
            btt_Exit.Text = "Exit";
            btt_Exit.UseVisualStyleBackColor = false;
            btt_Exit.Click += btt_Exit_Click;
            // 
            // SalePrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 182);
            Controls.Add(btt_Exit);
            Controls.Add(btt_Calculate);
            Controls.Add(lb_SalePrice);
            Controls.Add(label3);
            Controls.Add(txtb_Precent);
            Controls.Add(txtb_Price);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SalePrice";
            Text = "Sale Price";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtb_Price;
        private TextBox txtb_Precent;
        private Label label3;
        private Label lb_SalePrice;
        private Button btt_Calculate;
        private Button btt_Exit;
    }
}