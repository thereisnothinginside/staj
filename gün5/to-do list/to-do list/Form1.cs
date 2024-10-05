using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace to_do_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.Columns.Add("Tasks", 200);
            listView1.Columns.Add("Details", 200);
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Scrollable = true;

            textBox1.TabIndex = 1;
            textBoxDetails.TabIndex = 2;
            butonadd.TabIndex = 3;
            listView1.TabIndex = 4;
            butononline.TabIndex = 5;
            butonremove.TabIndex = 6;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            listView1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void butonadd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBoxDetails.Text))
            {
                listView1.Items.Add(new ListViewItem(new[] { textBox1.Text, textBoxDetails.Text }));
                textBox1.Clear();
                textBoxDetails.Clear();
                listView1.EnsureVisible(listView1.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Başlık ve açıklama giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butonremove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Silmek için bir görev seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butononline_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                if (item.Font.Style == FontStyle.Strikeout)
                {
                    item.ForeColor = Color.Black;
                    item.Font = new Font(item.Font, FontStyle.Regular);
                }
                else
                {
                    item.ForeColor = Color.Gray;
                    item.Font = new Font(item.Font, FontStyle.Strikeout);
                }
            }
            else
            {
                MessageBox.Show("Üstünü çizmek için bir görev seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float value = trackBar1.Value;
            float minValue = trackBar1.Minimum;
            float maxValue = trackBar1.Maximum;
            float opacity = (value - minValue) / (maxValue - minValue) * (1 - 0.1f) + 0.1f;
            this.Opacity = opacity;
        }

        private void copybuton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string taskText = selectedItem.Text;
                string detailsText = selectedItem.SubItems.Count > 1 ? selectedItem.SubItems[1].Text : "";
                string clipboardText =  detailsText;
                Clipboard.SetText(clipboardText);
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin.");
            }
        }

        private void clearall_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tüm görevleri silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                listView1.Items.Clear();
            }
        }
    }
}

