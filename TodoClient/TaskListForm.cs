using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TodoClient
{
    public partial class TaskListForm : Form
    {
        public TaskListForm()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        private void TaskListForm_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Title", typeof(int));
            tablo.Columns.Add("Category", typeof(string));
            tablo.Columns.Add("Description", typeof(int));
            tablo.Columns.Add("Status", typeof(bool));
            dataGridView1.DataSource = tablo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(textBox1.Text, comboBox1.Text, richTextBox1.Text, radioButton1.Text, radioButton2.Text);
            dataGridView1.DataSource = tablo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }
    }
}
