namespace to_do_list
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butonremove;
        private System.Windows.Forms.Button butonadd;
        private System.Windows.Forms.Button butononline;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butonremove = new System.Windows.Forms.Button();
            this.butonadd = new System.Windows.Forms.Button();
            this.butononline = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.copybuton = new System.Windows.Forms.Button();
            this.clearall = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 22);
            this.textBox1.TabIndex = 1;
            // 
            // butonremove
            // 
            this.butonremove.Location = new System.Drawing.Point(7, 91);
            this.butonremove.Name = "butonremove";
            this.butonremove.Size = new System.Drawing.Size(45, 23);
            this.butonremove.TabIndex = 2;
            this.butonremove.Text = "sil";
            this.butonremove.UseVisualStyleBackColor = true;
            this.butonremove.Click += new System.EventHandler(this.butonremove_Click);
            // 
            // butonadd
            // 
            this.butonadd.Location = new System.Drawing.Point(139, 91);
            this.butonadd.Name = "butonadd";
            this.butonadd.Size = new System.Drawing.Size(56, 23);
            this.butonadd.TabIndex = 3;
            this.butonadd.Text = "ekle";
            this.butonadd.UseVisualStyleBackColor = true;
            this.butonadd.Click += new System.EventHandler(this.butonadd_Click);
            // 
            // butononline
            // 
            this.butononline.Location = new System.Drawing.Point(58, 91);
            this.butononline.Name = "butononline";
            this.butononline.Size = new System.Drawing.Size(75, 23);
            this.butononline.TabIndex = 4;
            this.butononline.Text = "üstünü çiz";
            this.butononline.UseVisualStyleBackColor = true;
            this.butononline.Click += new System.EventHandler(this.butononline_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 148);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(513, 193);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.textBoxDetails.Location = new System.Drawing.Point(289, 37);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(231, 77);
            this.textBoxDetails.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "başlığınızı giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "açıklamamlarınızı giriniz";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.trackBar1.Location = new System.Drawing.Point(76, 65);
            this.trackBar1.Maximum = 30;
            this.trackBar1.MaximumSize = new System.Drawing.Size(100, 20);
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(100, 20);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 30;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // copybuton
            // 
            this.copybuton.Location = new System.Drawing.Point(126, 120);
            this.copybuton.Name = "copybuton";
            this.copybuton.Size = new System.Drawing.Size(69, 23);
            this.copybuton.TabIndex = 10;
            this.copybuton.Text = "kopyala";
            this.copybuton.UseVisualStyleBackColor = true;
            this.copybuton.Click += new System.EventHandler(this.copybuton_Click);
            // 
            // clearall
            // 
            this.clearall.Location = new System.Drawing.Point(7, 120);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(82, 23);
            this.clearall.TabIndex = 11;
            this.clearall.Text = "hepsini sil";
            this.clearall.UseVisualStyleBackColor = true;
            this.clearall.Click += new System.EventHandler(this.clearall_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "opaklık :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearall);
            this.Controls.Add(this.copybuton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.butononline);
            this.Controls.Add(this.butonadd);
            this.Controls.Add(this.butonremove);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "My To-Do List";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button copybuton;
        private System.Windows.Forms.Button clearall;
        private System.Windows.Forms.Label label3;
    }
}




