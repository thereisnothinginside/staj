using System;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace database_yedekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // DataGrid Columns
            dataGridFolders.ColumnCount = 1;
            dataGridFolders.Columns[0].Name = "Klasör Yolu";
            dataGridFolders.Columns[0].Width = 450;
            labuyar2.Visible = false;
        }

        private void pgnext1_Click_1(object sender, EventArgs e)
        {
            // Eğer TextBox'lar boşsa uyarı ver
            if (string.IsNullOrEmpty(txtTableName.Text) || string.IsNullOrEmpty(txtConnectionString.Text))
            {
                MessageBox.Show("Tablo adı ve bağlantı cümlesi boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Eğer doluysa 2. Sayfa'ya geç
                tabControl1.SelectedIndex = 1;
            }
        }

        private void btnBackup_Click_1(object sender, EventArgs e)
        {
            if (chkBackupDatabase.Checked)
            {
                string backupFolderPath = BackupDatabase();
                if (chkBackupFolders.Checked)
                {
                    string foldersBackupPath = BackupFolders();
                    if (!string.IsNullOrEmpty(backupFolderPath) && !string.IsNullOrEmpty(foldersBackupPath))
                    {
                        CreateZipFile(backupFolderPath, foldersBackupPath);
                    }
                }
                else
                {
                    CreateZipFile(backupFolderPath);
                }
            }
            else if (chkBackupFolders.Checked)
            {
                string foldersBackupPath = BackupFolders();
                if (!string.IsNullOrEmpty(foldersBackupPath))
                {
                    CreateZipFile(foldersBackupPath);
                }
            }
        }

        private string BackupDatabase()
        {
            try
            {
                string tableName = txtTableName.Text;
                string connectionString = txtConnectionString.Text;

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string backupFolderPath = GetUniqueFolderName(desktopPath, "yedek");
                Directory.CreateDirectory(backupFolderPath);

                string dateTimeFolderPath = Path.Combine(backupFolderPath, DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
                Directory.CreateDirectory(dateTimeFolderPath);

                string backupFilePath = Path.Combine(dateTimeFolderPath, $"{tableName}_Backup.bak");

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string backupQuery = $"BACKUP DATABASE {tableName} TO DISK = @backupPath";
                    using (SqlCommand command = new SqlCommand(backupQuery, connection))
                    {
                        command.Parameters.AddWithValue("@backupPath", backupFilePath);
                        command.ExecuteNonQuery();
                    }
                }

                return dateTimeFolderPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı yedekleme hatası: {ex.Message}");
                return null;
            }
        }

        private string BackupFolders()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string backupFolderPath = GetUniqueFolderName(desktopPath, "yedek");
                Directory.CreateDirectory(backupFolderPath);

                string dateTimeFolderPath = Path.Combine(backupFolderPath, DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
                Directory.CreateDirectory(dateTimeFolderPath);

                foreach (DataGridViewRow row in dataGridFolders.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string folderPath = row.Cells[0].Value.ToString();
                        string backupFolder = Path.Combine(dateTimeFolderPath, Path.GetFileName(folderPath));
                        CopyDirectory(folderPath, backupFolder);
                    }
                }

                return dateTimeFolderPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klasör yedekleme hatası: {ex.Message}");
                return null;
            }
        }

        private void CreateZipFile(params string[] folderPaths)
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string zipFilePath = Path.Combine(desktopPath, $"yedek_{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.zip");

                using (ZipArchive zipArchive = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
                {
                    foreach (string folderPath in folderPaths)
                    {
                        if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
                        {
                            foreach (string file in Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories))
                            {
                                string entryName = GetRelativePath(folderPath, file);
                                zipArchive.CreateEntryFromFile(file, entryName);
                            }
                        }
                    }
                }

                MessageBox.Show($"Yedekleme zip dosyası oluşturuldu: {zipFilePath}");
                foreach (string folderPath in folderPaths)
                {
                    if (Directory.Exists(folderPath))
                    {
                        Directory.Delete(folderPath, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Zip dosyası oluşturma hatası: {ex.Message}");
            }
        }

        private string GetUniqueFolderName(string basePath, string baseFolderName)
        {
            string folderPath = Path.Combine(basePath, baseFolderName);
            int counter = 1;

            while (Directory.Exists(folderPath))
            {
                folderPath = Path.Combine(basePath, $"{baseFolderName}{counter}");
                counter++;
            }

            return folderPath;
        }

        private void CopyDirectory(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var dir in Directory.GetDirectories(sourceDir, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dir.Replace(sourceDir, targetDir));
            }

            foreach (var file in Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(file, file.Replace(sourceDir, targetDir), true);
            }
        }

        private string GetRelativePath(string relativeTo, string path)
        {
            Uri fromUri = new Uri(AppendDirectorySeparatorChar(relativeTo));
            Uri toUri = new Uri(AppendDirectorySeparatorChar(path));

            Uri relativeUri = fromUri.MakeRelativeUri(toUri);
            string relativePath = Uri.UnescapeDataString(relativeUri.ToString());

            return relativePath.Replace('/', Path.DirectorySeparatorChar);
        }

        private string AppendDirectorySeparatorChar(string path)
        {
            if (!path.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal))
            {
                return path + Path.DirectorySeparatorChar;
            }

            return path;
        }

        private void btnRemoveFolder_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridFolders.SelectedRows)
                {
                    dataGridFolders.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DİKKAT!  " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkBackupFolders_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text) || string.IsNullOrEmpty(txtTableName.Text))
            {
                tabControl1.SelectedIndex = 2;
            }
        }

        private void chkBackupDatabase_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


/*


        private void pgnext1_Click_1(object sender, EventArgs e)
        {
            // Eğer TextBox'lar boşsa uyarı ver
            if (string.IsNullOrEmpty(txtTableName.Text) || string.IsNullOrEmpty(txtConnectionString.Text))
            {
                MessageBox.Show("Tablo adı ve bağlantı cümlesi boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Eğer doluysa 2. Sayfa'ya geç
                tabControl1.SelectedIndex = 1;
            }
        }

        private void btnBackup_Click_1(object sender, EventArgs e)
        {
            if (chkBackupDatabase.Checked)
            {
                string backupFolderPath = BackupDatabase();
                if (chkBackupFolders.Checked)
                {
                    string foldersBackupPath = BackupFolders();
                    if (!string.IsNullOrEmpty(backupFolderPath) && !string.IsNullOrEmpty(foldersBackupPath))
                    {
                        CreateZipFile(backupFolderPath, foldersBackupPath);
                    }
                }
                else
                {
                    CreateZipFile(backupFolderPath);
                }
            }
            else if (chkBackupFolders.Checked)
            {
                string foldersBackupPath = BackupFolders();
                if (!string.IsNullOrEmpty(foldersBackupPath))
                {
                    CreateZipFile(foldersBackupPath);
                }
            }
        }

        private string BackupDatabase()
        {
            try
            {
                string tableName = txtTableName.Text;
                string connectionString = txtConnectionString.Text;

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string backupFolderPath = GetUniqueFolderName(desktopPath, "yedek");
                Directory.CreateDirectory(backupFolderPath);

                string dateTimeFolderPath = Path.Combine(backupFolderPath, DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
                Directory.CreateDirectory(dateTimeFolderPath);

                string backupFilePath = Path.Combine(dateTimeFolderPath, $"{tableName}_Backup.bak");

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string backupQuery = $"BACKUP DATABASE {tableName} TO DISK = @backupPath";
                    using (SqlCommand command = new SqlCommand(backupQuery, connection))
                    {
                        command.Parameters.AddWithValue("@backupPath", backupFilePath);
                        command.ExecuteNonQuery();
                    }
                }

                return dateTimeFolderPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı yedekleme hatası: {ex.Message}");
                return null;
            }
        }

        private string BackupFolders()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string backupFolderPath = GetUniqueFolderName(desktopPath, "yedek");
                Directory.CreateDirectory(backupFolderPath);

                string dateTimeFolderPath = Path.Combine(backupFolderPath, DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
                Directory.CreateDirectory(dateTimeFolderPath);

                foreach (DataGridViewRow row in dataGridFolders.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string folderPath = row.Cells[0].Value.ToString();
                        string backupFolder = Path.Combine(dateTimeFolderPath, Path.GetFileName(folderPath));
                        CopyDirectory(folderPath, backupFolder);
                    }
                }

                return dateTimeFolderPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klasör yedekleme hatası: {ex.Message}");
                return null;
            }
        }

        private void CreateZipFile(params string[] folderPaths)
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string zipFilePath = Path.Combine(desktopPath, $"yedek_{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.zip");

                using (ZipArchive zipArchive = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
                {
                    foreach (string folderPath in folderPaths)
                    {
                        if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
                        {
                            foreach (string file in Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories))
                            {
                                string entryName = Path.GetRelativePath(folderPath, file);
                                zipArchive.CreateEntryFromFile(file, entryName);
                            }
                        }
                    }
                }

                MessageBox.Show($"Yedekleme zip dosyası oluşturuldu: {zipFilePath}");
                foreach (string folderPath in folderPaths)
                {
                    if (Directory.Exists(folderPath))
                    {
                        Directory.Delete(folderPath, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Zip dosyası oluşturma hatası: {ex.Message}");
            }
        }

        private string GetUniqueFolderName(string basePath, string baseFolderName)
        {
            string folderPath = Path.Combine(basePath, baseFolderName);
            int counter = 1;

            while (Directory.Exists(folderPath))
            {
                folderPath = Path.Combine(basePath, $"{baseFolderName}{counter}");
                counter++;
            }

            return folderPath;
        }

        private void CopyDirectory(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var dir in Directory.GetDirectories(sourceDir, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dir.Replace(sourceDir, targetDir));
            }

            foreach (var file in Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(file, file.Replace(sourceDir, targetDir), true);
            }
        }

        private void btnRemoveFolder_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridFolders.SelectedRows)
                {
                    dataGridFolders.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DİKKAT!  " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkBackupFolders_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text) || string.IsNullOrEmpty(txtTableName.Text))
            {
                tabControl1.SelectedIndex = 2;
            }
        }
    }
}
*/