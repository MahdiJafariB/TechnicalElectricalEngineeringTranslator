using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEET_Data;
using TEET_Data.Repository;

namespace TEET_App
{
    public partial class SplitterForm : Form
    {
        public List<string> Bag;

        public SplitterForm()
        {
            InitializeComponent();
        }

        Repository repository;

        string NormalText(string? text)
        {
            if (string.IsNullOrEmpty(text)) 
                throw new ArgumentNullException("text, Splitter From");
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
        }

        private void SplitterForm_Load(object sender, EventArgs e)
        {
            if (Bag.Any())
            {
                dgvInsert.Rows.Clear();
                foreach (var item in Bag)
                {
                    dgvInsert.Rows.Add(item, "", "", "Insert");
                }
                repository = new Repository(Application.StartupPath + "Data.svg");
            }
            dgvInsert.Rows.Add("Save Changes", "-", "-", "Save");
        }

        private void dgvInsert_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInsert.Columns[3].Index)
            {
                if (dgvInsert.CurrentRow.Cells[3].Value.ToString() == "Save")
                {
                    repository.Save();
                    MessageBox.Show("Inserted data are saved!");
                    return;
                }

                Word word = new()
                {
                    WordFace = NormalText(dgvInsert.CurrentRow.Cells[0].Value.ToString()),
                    WordEnglishMean = NormalText(dgvInsert.CurrentRow.Cells[1].Value.ToString()),
                    WordPersianMean = dgvInsert.CurrentRow.Cells[2].Value.ToString()
                };
                if (repository.Insert(word))
                    MessageBox.Show("Insert Succeed", "Message");
                else
                    MessageBox.Show("Something went wrong", "Message");
            }
        }
    }
}
