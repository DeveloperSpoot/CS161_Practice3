namespace Practice_3
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btt_BirthDate = new Button();
            btt_FuelEcon = new Button();
            btt_SalePrice = new Button();
            btt_TestAvg = new Button();
            btt_ChangeCounter = new Button();
            btt_SingleStep = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btt_BirthDate
            // 
            btt_BirthDate.Location = new Point(12, 79);
            btt_BirthDate.Name = "btt_BirthDate";
            btt_BirthDate.Size = new Size(75, 23);
            btt_BirthDate.TabIndex = 0;
            btt_BirthDate.Text = "Birth Date";
            btt_BirthDate.UseVisualStyleBackColor = true;
            btt_BirthDate.Click += btt_BirthDate_Click;
            // 
            // btt_FuelEcon
            // 
            btt_FuelEcon.Location = new Point(12, 123);
            btt_FuelEcon.Name = "btt_FuelEcon";
            btt_FuelEcon.Size = new Size(75, 23);
            btt_FuelEcon.TabIndex = 1;
            btt_FuelEcon.Text = "Fuel Econ";
            btt_FuelEcon.UseVisualStyleBackColor = true;
            btt_FuelEcon.Click += btt_FuelEcon_Click;
            // 
            // btt_SalePrice
            // 
            btt_SalePrice.Location = new Point(12, 162);
            btt_SalePrice.Name = "btt_SalePrice";
            btt_SalePrice.Size = new Size(75, 23);
            btt_SalePrice.TabIndex = 2;
            btt_SalePrice.Text = "Sale Price";
            btt_SalePrice.UseVisualStyleBackColor = true;
            btt_SalePrice.Click += btt_SalePrice_Click;
            // 
            // btt_TestAvg
            // 
            btt_TestAvg.Location = new Point(128, 79);
            btt_TestAvg.Name = "btt_TestAvg";
            btt_TestAvg.Size = new Size(75, 23);
            btt_TestAvg.TabIndex = 3;
            btt_TestAvg.Text = "Test Avg";
            btt_TestAvg.UseVisualStyleBackColor = true;
            btt_TestAvg.Click += btt_TestAvg_Click;
            // 
            // btt_ChangeCounter
            // 
            btt_ChangeCounter.Location = new Point(128, 123);
            btt_ChangeCounter.Name = "btt_ChangeCounter";
            btt_ChangeCounter.Size = new Size(75, 23);
            btt_ChangeCounter.TabIndex = 4;
            btt_ChangeCounter.Text = "Change";
            btt_ChangeCounter.UseVisualStyleBackColor = true;
            btt_ChangeCounter.Click += btt_ChangeCounter_Click;
            // 
            // btt_SingleStep
            // 
            btt_SingleStep.Location = new Point(128, 162);
            btt_SingleStep.Name = "btt_SingleStep";
            btt_SingleStep.Size = new Size(75, 23);
            btt_SingleStep.TabIndex = 5;
            btt_SingleStep.Text = "Single-Step";
            btt_SingleStep.UseVisualStyleBackColor = true;
            btt_SingleStep.Click += btt_SingleStep_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 6;
            label1.Text = "Practice 3";
            // 
            // button1
            // 
            button1.Location = new Point(242, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Name Formatter";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(242, 123);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Name Formatter";
            button2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 220);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btt_SingleStep);
            Controls.Add(btt_ChangeCounter);
            Controls.Add(btt_TestAvg);
            Controls.Add(btt_SalePrice);
            Controls.Add(btt_FuelEcon);
            Controls.Add(btt_BirthDate);
            Name = "Main";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btt_BirthDate;
        private Button btt_FuelEcon;
        private Button btt_SalePrice;
        private Button btt_TestAvg;
        private Button btt_ChangeCounter;
        private Button btt_SingleStep;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}
