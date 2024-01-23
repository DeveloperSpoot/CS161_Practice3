namespace Practice_3.Programming_Problems
{
    partial class TipTaxTotal
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
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Display = new System.Windows.Forms.Label();
            this.btt_Total = new System.Windows.Forms.Button();
            this.txtb_Bill = new System.Windows.Forms.TextBox();
            this.txtb_Tip = new System.Windows.Forms.TextBox();
            this.txtb_Tax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sales Tax %";
            // 
            // lb_Display
            // 
            this.lb_Display.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Display.Location = new System.Drawing.Point(124, 166);
            this.lb_Display.Name = "lb_Display";
            this.lb_Display.Size = new System.Drawing.Size(119, 27);
            this.lb_Display.TabIndex = 3;
            this.lb_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btt_Total
            // 
            this.btt_Total.Location = new System.Drawing.Point(20, 155);
            this.btt_Total.Name = "btt_Total";
            this.btt_Total.Size = new System.Drawing.Size(84, 49);
            this.btt_Total.TabIndex = 4;
            this.btt_Total.Text = "Calculate Total";
            this.btt_Total.UseVisualStyleBackColor = true;
            this.btt_Total.Click += new System.EventHandler(this.btt_Total_Click);
            // 
            // txtb_Bill
            // 
            this.txtb_Bill.Location = new System.Drawing.Point(124, 28);
            this.txtb_Bill.Name = "txtb_Bill";
            this.txtb_Bill.Size = new System.Drawing.Size(119, 26);
            this.txtb_Bill.TabIndex = 5;
            // 
            // txtb_Tip
            // 
            this.txtb_Tip.Location = new System.Drawing.Point(124, 74);
            this.txtb_Tip.Name = "txtb_Tip";
            this.txtb_Tip.Size = new System.Drawing.Size(119, 26);
            this.txtb_Tip.TabIndex = 6;
            // 
            // txtb_Tax
            // 
            this.txtb_Tax.Location = new System.Drawing.Point(124, 119);
            this.txtb_Tax.Name = "txtb_Tax";
            this.txtb_Tax.Size = new System.Drawing.Size(119, 26);
            this.txtb_Tax.TabIndex = 7;
            // 
            // TipTaxTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 213);
            this.Controls.Add(this.txtb_Tax);
            this.Controls.Add(this.txtb_Tip);
            this.Controls.Add(this.txtb_Bill);
            this.Controls.Add(this.btt_Total);
            this.Controls.Add(this.lb_Display);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TipTaxTotal";
            this.Text = "TipTaxTotal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lb_Display;
        private Button btt_Total;
        private TextBox txtb_Bill;
        private TextBox txtb_Tip;
        private TextBox txtb_Tax;
    }
}