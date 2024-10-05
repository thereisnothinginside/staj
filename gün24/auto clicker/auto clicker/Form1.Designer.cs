namespace GlobalClicker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonBasla = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.LawnGreen;
            this.button2.Location = new System.Drawing.Point(12, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "konum seç";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(135, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "bekleniyor";
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX.Location = new System.Drawing.Point(33, 75);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(50, 15);
            this.textBoxX.TabIndex = 2;
            // 
            // textBoxY
            // 
            this.textBoxY.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxY.Location = new System.Drawing.Point(33, 104);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(50, 15);
            this.textBoxY.TabIndex = 3;
            // 
            // buttonBasla
            // 
            this.buttonBasla.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonBasla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBasla.CausesValidation = false;
            this.buttonBasla.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonBasla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBasla.ForeColor = System.Drawing.Color.Lime;
            this.buttonBasla.Location = new System.Drawing.Point(138, 76);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(100, 50);
            this.buttonBasla.TabIndex = 4;
            this.buttonBasla.Text = "başla";
            this.buttonBasla.UseVisualStyleBackColor = false;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.ForeColor = System.Drawing.Color.Cyan;
            this.labelX.Location = new System.Drawing.Point(12, 78);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(15, 16);
            this.labelX.TabIndex = 5;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.ForeColor = System.Drawing.Color.Cyan;
            this.labelY.Location = new System.Drawing.Point(11, 104);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(16, 16);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "Y";
            // 
            // textBoxCount
            // 
            this.textBoxCount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCount.Location = new System.Drawing.Point(138, 137);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 15);
            this.textBoxCount.TabIndex = 7;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.ForeColor = System.Drawing.Color.Indigo;
            this.labelCount.Location = new System.Drawing.Point(11, 140);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(120, 16);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "kaç kere tıklansın ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(-1, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "@ Made By Mehmet Emre Çetinkaya";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(260, 198);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.buttonBasla);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Auto Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label2;
    }
}
