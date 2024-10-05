namespace database_yedekleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkBackupDatabase = new System.Windows.Forms.CheckBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.chkBackupFolders = new System.Windows.Forms.CheckBox();
            this.txtSelectedFolder = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labuyar2 = new System.Windows.Forms.Label();
            this.bosyazı2 = new System.Windows.Forms.Label();
            this.bosyazı1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnRemoveFolder = new System.Windows.Forms.Button();
            this.dataGridFolders = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("MingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(14)))), ((int)(((byte)(10)))));
            label1.Location = new System.Drawing.Point(82, 185);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(455, 15);
            label1.TabIndex = 5;
            label1.Text = "yedeklenecek klasörün nereye yedekleneceğini seçin";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-7, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 413);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(189)))));
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Controls.Add(this.chkBackupDatabase);
            this.tabPage1.Controls.Add(this.btnSelectFolder);
            this.tabPage1.Controls.Add(this.chkBackupFolders);
            this.tabPage1.Controls.Add(this.txtSelectedFolder);
            this.tabPage1.Controls.Add(this.btnBackup);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yedekle";
            // 
            // chkBackupDatabase
            // 
            this.chkBackupDatabase.AutoSize = true;
            this.chkBackupDatabase.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBackupDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(26)))), ((int)(((byte)(134)))));
            this.chkBackupDatabase.Location = new System.Drawing.Point(85, 52);
            this.chkBackupDatabase.Name = "chkBackupDatabase";
            this.chkBackupDatabase.Size = new System.Drawing.Size(186, 23);
            this.chkBackupDatabase.TabIndex = 0;
            this.chkBackupDatabase.Text = "veritabanını yedekle";
            this.chkBackupDatabase.UseVisualStyleBackColor = true;
            this.chkBackupDatabase.CheckedChanged += new System.EventHandler(this.chkBackupDatabase_CheckedChanged);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(453, 139);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(42, 23);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "seç";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            // 
            // chkBackupFolders
            // 
            this.chkBackupFolders.AutoSize = true;
            this.chkBackupFolders.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBackupFolders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(26)))), ((int)(((byte)(134)))));
            this.chkBackupFolders.Location = new System.Drawing.Point(85, 88);
            this.chkBackupFolders.Name = "chkBackupFolders";
            this.chkBackupFolders.Size = new System.Drawing.Size(167, 23);
            this.chkBackupFolders.TabIndex = 1;
            this.chkBackupFolders.Text = "klasörleri yedekle";
            this.chkBackupFolders.UseVisualStyleBackColor = true;
            this.chkBackupFolders.CheckedChanged += new System.EventHandler(this.chkBackupFolders_CheckedChanged);
            // 
            // txtSelectedFolder
            // 
            this.txtSelectedFolder.Location = new System.Drawing.Point(85, 139);
            this.txtSelectedFolder.Name = "txtSelectedFolder";
            this.txtSelectedFolder.Size = new System.Drawing.Size(327, 22);
            this.txtSelectedFolder.TabIndex = 2;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(119)))), ((int)(((byte)(83)))));
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(26)))), ((int)(((byte)(134)))));
            this.btnBackup.Location = new System.Drawing.Point(542, 52);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(120, 59);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "yedekle";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(189)))));
            this.tabPage2.Controls.Add(this.labuyar2);
            this.tabPage2.Controls.Add(this.bosyazı2);
            this.tabPage2.Controls.Add(this.bosyazı1);
            this.tabPage2.Controls.Add(this.txtTableName);
            this.tabPage2.Controls.Add(this.txtConnectionString);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Veritabanı Ayarları";
            // 
            // labuyar2
            // 
            this.labuyar2.AutoSize = true;
            this.labuyar2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labuyar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(14)))), ((int)(((byte)(10)))));
            this.labuyar2.Location = new System.Drawing.Point(225, 190);
            this.labuyar2.Name = "labuyar2";
            this.labuyar2.Size = new System.Drawing.Size(276, 20);
            this.labuyar2.TabIndex = 4;
            this.labuyar2.Text = "buradaki 2 değerde boş kalamaz";
            // 
            // bosyazı2
            // 
            this.bosyazı2.AutoSize = true;
            this.bosyazı2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bosyazı2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(26)))), ((int)(((byte)(134)))));
            this.bosyazı2.Location = new System.Drawing.Point(31, 143);
            this.bosyazı2.Name = "bosyazı2";
            this.bosyazı2.Size = new System.Drawing.Size(158, 19);
            this.bosyazı2.TabIndex = 2;
            this.bosyazı2.Text = "ConnectionString :";
            // 
            // bosyazı1
            // 
            this.bosyazı1.AutoSize = true;
            this.bosyazı1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bosyazı1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(26)))), ((int)(((byte)(134)))));
            this.bosyazı1.Location = new System.Drawing.Point(31, 80);
            this.bosyazı1.Name = "bosyazı1";
            this.bosyazı1.Size = new System.Drawing.Size(76, 19);
            this.bosyazı1.TabIndex = 3;
            this.bosyazı1.Text = "tablo adı";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(229, 80);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(486, 22);
            this.txtTableName.TabIndex = 0;
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(229, 143);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(486, 22);
            this.txtConnectionString.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(189)))));
            this.tabPage5.Controls.Add(this.btnAddFolder);
            this.tabPage5.Controls.Add(this.btnRemoveFolder);
            this.tabPage5.Controls.Add(this.dataGridFolders);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(711, 384);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Dosya Ayarları";
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.BackColor = System.Drawing.Color.Coral;
            this.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(26)))), ((int)(((byte)(134)))));
            this.btnAddFolder.Location = new System.Drawing.Point(585, 19);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(95, 48);
            this.btnAddFolder.TabIndex = 2;
            this.btnAddFolder.Text = "klasör ekle";
            this.btnAddFolder.UseVisualStyleBackColor = false;
            // 
            // btnRemoveFolder
            // 
            this.btnRemoveFolder.BackColor = System.Drawing.Color.Coral;
            this.btnRemoveFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(26)))), ((int)(((byte)(134)))));
            this.btnRemoveFolder.Location = new System.Drawing.Point(35, 19);
            this.btnRemoveFolder.Name = "btnRemoveFolder";
            this.btnRemoveFolder.Size = new System.Drawing.Size(75, 48);
            this.btnRemoveFolder.TabIndex = 1;
            this.btnRemoveFolder.Text = "sil";
            this.btnRemoveFolder.UseVisualStyleBackColor = false;
            this.btnRemoveFolder.Click += new System.EventHandler(this.btnRemoveFolder_Click_1);
            // 
            // dataGridFolders
            // 
            this.dataGridFolders.AllowUserToOrderColumns = true;
            this.dataGridFolders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(233)))), ((int)(((byte)(175)))));
            this.dataGridFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFolders.Location = new System.Drawing.Point(35, 104);
            this.dataGridFolders.Name = "dataGridFolders";
            this.dataGridFolders.RowHeadersWidth = 51;
            this.dataGridFolders.RowTemplate.Height = 24;
            this.dataGridFolders.Size = new System.Drawing.Size(645, 267);
            this.dataGridFolders.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(707, 409);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label bosyazı1;
        private System.Windows.Forms.Label bosyazı2;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox chkBackupFolders;
        private System.Windows.Forms.CheckBox chkBackupDatabase;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtSelectedFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridFolders;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnRemoveFolder;
        private System.Windows.Forms.Label labuyar2;
    }
}

