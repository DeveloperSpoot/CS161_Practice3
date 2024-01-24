namespace Practice_3.Programming_Problems
{
    partial class CelsiusFahrenheit
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
            this.gp_Scale = new System.Windows.Forms.GroupBox();
            this.radBtt_Celsius = new System.Windows.Forms.RadioButton();
            this.radBtt_Fahrenheit = new System.Windows.Forms.RadioButton();
            this.lb_TempTitle = new System.Windows.Forms.Label();
            this.lb_Display = new System.Windows.Forms.Label();
            this.txtb_Temperature = new System.Windows.Forms.TextBox();
            this.lb_Scale = new System.Windows.Forms.Label();
            this.gp_Scale.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_Scale
            // 
            this.gp_Scale.Controls.Add(this.radBtt_Celsius);
            this.gp_Scale.Controls.Add(this.radBtt_Fahrenheit);
            this.gp_Scale.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gp_Scale.Location = new System.Drawing.Point(26, 64);
            this.gp_Scale.Name = "gp_Scale";
            this.gp_Scale.Size = new System.Drawing.Size(314, 52);
            this.gp_Scale.TabIndex = 0;
            this.gp_Scale.TabStop = false;
            this.gp_Scale.Text = "Select Scale To Use";
            // 
            // radBtt_Celsius
            // 
            this.radBtt_Celsius.AutoSize = true;
            this.radBtt_Celsius.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtt_Celsius.Location = new System.Drawing.Point(142, 22);
            this.radBtt_Celsius.Name = "radBtt_Celsius";
            this.radBtt_Celsius.Size = new System.Drawing.Size(72, 24);
            this.radBtt_Celsius.TabIndex = 1;
            this.radBtt_Celsius.Text = "Celsius";
            this.radBtt_Celsius.UseVisualStyleBackColor = true;
            this.radBtt_Celsius.CheckedChanged += new System.EventHandler(this.radBtt_Celsius_CheckedChanged);
            // 
            // radBtt_Fahrenheit
            // 
            this.radBtt_Fahrenheit.AutoSize = true;
            this.radBtt_Fahrenheit.Checked = true;
            this.radBtt_Fahrenheit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtt_Fahrenheit.Location = new System.Drawing.Point(6, 22);
            this.radBtt_Fahrenheit.Name = "radBtt_Fahrenheit";
            this.radBtt_Fahrenheit.Size = new System.Drawing.Size(99, 24);
            this.radBtt_Fahrenheit.TabIndex = 0;
            this.radBtt_Fahrenheit.TabStop = true;
            this.radBtt_Fahrenheit.Text = "Fahrenheit ";
            this.radBtt_Fahrenheit.UseVisualStyleBackColor = true;
            this.radBtt_Fahrenheit.CheckedChanged += new System.EventHandler(this.radBtt_Fahrenheit_CheckedChanged);
            // 
            // lb_TempTitle
            // 
            this.lb_TempTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TempTitle.Location = new System.Drawing.Point(28, 25);
            this.lb_TempTitle.Name = "lb_TempTitle";
            this.lb_TempTitle.Size = new System.Drawing.Size(143, 21);
            this.lb_TempTitle.TabIndex = 1;
            this.lb_TempTitle.Text = "Enter Temperature";
            // 
            // lb_Display
            // 
            this.lb_Display.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Display.Location = new System.Drawing.Point(92, 132);
            this.lb_Display.Name = "lb_Display";
            this.lb_Display.Size = new System.Drawing.Size(178, 37);
            this.lb_Display.TabIndex = 2;
            this.lb_Display.Text = "Keep on slaying.";
            this.lb_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb_Temperature
            // 
            this.txtb_Temperature.Location = new System.Drawing.Point(177, 22);
            this.txtb_Temperature.Name = "txtb_Temperature";
            this.txtb_Temperature.Size = new System.Drawing.Size(114, 26);
            this.txtb_Temperature.TabIndex = 3;
            this.txtb_Temperature.TextChanged += new System.EventHandler(this.txtb_Temperature_TextChanged);
            // 
            // lb_Scale
            // 
            this.lb_Scale.Location = new System.Drawing.Point(296, 24);
            this.lb_Scale.Name = "lb_Scale";
            this.lb_Scale.Size = new System.Drawing.Size(46, 23);
            this.lb_Scale.TabIndex = 4;
            this.lb_Scale.Text = "°C";
            this.lb_Scale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CelsiusFahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 190);
            this.Controls.Add(this.lb_Scale);
            this.Controls.Add(this.txtb_Temperature);
            this.Controls.Add(this.lb_Display);
            this.Controls.Add(this.lb_TempTitle);
            this.Controls.Add(this.gp_Scale);
            this.Name = "CelsiusFahrenheit";
            this.Text = "CelsiusFahrenheit";
            this.gp_Scale.ResumeLayout(false);
            this.gp_Scale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gp_Scale;
        private RadioButton radBtt_Fahrenheit;
        private Label lb_TempTitle;
        private Label lb_Display;
        private TextBox txtb_Temperature;
        private RadioButton radBtt_Celsius;
        private Label lb_Scale;
    }
}