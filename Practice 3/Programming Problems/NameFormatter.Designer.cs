namespace Practice_3.Programming_Problems
{
    partial class NameFormatter
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
            this.txtb_Title = new System.Windows.Forms.TextBox();
            this.txtb_First = new System.Windows.Forms.TextBox();
            this.txtb_Middle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_Last = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_Field1 = new System.Windows.Forms.ComboBox();
            this.lb_Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // txtb_Title
            // 
            this.txtb_Title.Location = new System.Drawing.Point(155, 16);
            this.txtb_Title.Name = "txtb_Title";
            this.txtb_Title.Size = new System.Drawing.Size(178, 26);
            this.txtb_Title.TabIndex = 5;
            // 
            // txtb_First
            // 
            this.txtb_First.Location = new System.Drawing.Point(155, 62);
            this.txtb_First.Name = "txtb_First";
            this.txtb_First.Size = new System.Drawing.Size(178, 26);
            this.txtb_First.TabIndex = 6;
            // 
            // txtb_Middle
            // 
            this.txtb_Middle.Location = new System.Drawing.Point(155, 115);
            this.txtb_Middle.Name = "txtb_Middle";
            this.txtb_Middle.Size = new System.Drawing.Size(178, 26);
            this.txtb_Middle.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Middle Name";
            // 
            // txtb_Last
            // 
            this.txtb_Last.Location = new System.Drawing.Point(155, 167);
            this.txtb_Last.Name = "txtb_Last";
            this.txtb_Last.Size = new System.Drawing.Size(178, 26);
            this.txtb_Last.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(138, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select Format Style";
            // 
            // combo_Field1
            // 
            this.combo_Field1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Field1.FormattingEnabled = true;
            this.combo_Field1.Items.AddRange(new object[] {
            "Title, First Middle Last",
            "First Midle Last",
            "First Last",
            "Last, First Middle, Title.",
            "Last, First Middle",
            "Last, First"});
            this.combo_Field1.Location = new System.Drawing.Point(96, 248);
            this.combo_Field1.Name = "combo_Field1";
            this.combo_Field1.Size = new System.Drawing.Size(222, 27);
            this.combo_Field1.TabIndex = 13;
            this.combo_Field1.SelectedIndexChanged += new System.EventHandler(this.combo_Field1_SelectedIndexChanged);
            // 
            // lb_Display
            // 
            this.lb_Display.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Display.Location = new System.Drawing.Point(54, 294);
            this.lb_Display.Name = "lb_Display";
            this.lb_Display.Size = new System.Drawing.Size(307, 36);
            this.lb_Display.TabIndex = 17;
            this.lb_Display.Text = "Your Formatted Name Will Be Displayed Here";
            this.lb_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameFormatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 339);
            this.Controls.Add(this.lb_Display);
            this.Controls.Add(this.combo_Field1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_Last);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb_Middle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_First);
            this.Controls.Add(this.txtb_Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NameFormatter";
            this.Text = "NameFormatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtb_Title;
        private TextBox txtb_First;
        private TextBox txtb_Middle;
        private Label label3;
        private TextBox txtb_Last;
        private Label label4;
        private Label label5;
        private ComboBox combo_Field1;
        private Label lb_Display;
    }
}