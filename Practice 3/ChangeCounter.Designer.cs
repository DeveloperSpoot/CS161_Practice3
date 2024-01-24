namespace Practice_3
{
    partial class ChangeCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCounter));
            button1 = new Button();
            picb_fiveCents = new PictureBox();
            picb_tenCents = new PictureBox();
            picb_twentyfiveCents = new PictureBox();
            picb_fiftyCents = new PictureBox();
            lb_Display = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picb_fiveCents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picb_tenCents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picb_twentyfiveCents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picb_fiftyCents).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(234, 273);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // picb_fiveCents
            // 
            picb_fiveCents.Image = (Image)resources.GetObject("picb_fiveCents.Image");
            picb_fiveCents.Location = new Point(38, 38);
            picb_fiveCents.Name = "picb_fiveCents";
            picb_fiveCents.Size = new Size(90, 90);
            picb_fiveCents.SizeMode = PictureBoxSizeMode.StretchImage;
            picb_fiveCents.TabIndex = 1;
            picb_fiveCents.TabStop = false;
            picb_fiveCents.Click += picb_fiveCents_Click;
            // 
            // picb_tenCents
            // 
            picb_tenCents.Image = (Image)resources.GetObject("picb_tenCents.Image");
            picb_tenCents.Location = new Point(162, 38);
            picb_tenCents.Name = "picb_tenCents";
            picb_tenCents.Size = new Size(90, 90);
            picb_tenCents.SizeMode = PictureBoxSizeMode.StretchImage;
            picb_tenCents.TabIndex = 2;
            picb_tenCents.TabStop = false;
            picb_tenCents.Click += picb_tenCents_Click;
            // 
            // picb_twentyfiveCents
            // 
            picb_twentyfiveCents.Image = (Image)resources.GetObject("picb_twentyfiveCents.Image");
            picb_twentyfiveCents.Location = new Point(286, 38);
            picb_twentyfiveCents.Name = "picb_twentyfiveCents";
            picb_twentyfiveCents.Size = new Size(90, 90);
            picb_twentyfiveCents.SizeMode = PictureBoxSizeMode.StretchImage;
            picb_twentyfiveCents.TabIndex = 3;
            picb_twentyfiveCents.TabStop = false;
            picb_twentyfiveCents.Click += picb_twentyfiveCents_Click;
            // 
            // picb_fiftyCents
            // 
            picb_fiftyCents.Image = (Image)resources.GetObject("picb_fiftyCents.Image");
            picb_fiftyCents.Location = new Point(410, 38);
            picb_fiftyCents.Name = "picb_fiftyCents";
            picb_fiftyCents.Size = new Size(90, 90);
            picb_fiftyCents.SizeMode = PictureBoxSizeMode.StretchImage;
            picb_fiftyCents.TabIndex = 4;
            picb_fiftyCents.TabStop = false;
            picb_fiftyCents.Click += picb_fiftyCents_Click;
            // 
            // lb_Display
            // 
            lb_Display.BackColor = SystemColors.ControlDark;
            lb_Display.BorderStyle = BorderStyle.FixedSingle;
            lb_Display.ForeColor = SystemColors.ButtonHighlight;
            lb_Display.Location = new Point(211, 207);
            lb_Display.Name = "lb_Display";
            lb_Display.Size = new Size(121, 28);
            lb_Display.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(247, 174);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 6;
            label2.Text = "Total";
            // 
            // ChangeCounter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 308);
            Controls.Add(label2);
            Controls.Add(lb_Display);
            Controls.Add(picb_fiftyCents);
            Controls.Add(picb_twentyfiveCents);
            Controls.Add(picb_tenCents);
            Controls.Add(picb_fiveCents);
            Controls.Add(button1);
            Name = "ChangeCounter";
            Text = "ChangeCounter";
            ((System.ComponentModel.ISupportInitialize)picb_fiveCents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picb_tenCents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picb_twentyfiveCents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picb_fiftyCents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox picb_fiveCents;
        private PictureBox picb_tenCents;
        private PictureBox picb_twentyfiveCents;
        private PictureBox picb_fiftyCents;
        private Label lb_Display;
        private Label label2;
    }
}