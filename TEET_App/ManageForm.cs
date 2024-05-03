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
    public partial class ManageForm : Form
    {
#pragma warning disable CS8618
        public ManageForm()
        {
            InitializeComponent();
        }

        Repository repository;
#pragma warning restore CS8618
        string NormalText(string text)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
        }

        void BindGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in repository.GetAllWords())
            {
                dataGridView1.Rows.Add(item.WordID, item.WordFace, item.WordEnglishMean, item.WordPersianMean);
            }
        }

        void BindGrid(IEnumerable<Word> words)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in words)
            {
                dataGridView1.Rows.Add(item.WordID, item.WordFace, item.WordEnglishMean, item.WordPersianMean);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Word word = new Word
            {
                WordFace = NormalText(txtFace.Text),
                WordEnglishMean = NormalText(txtEnMean.Text),
                WordPersianMean = NormalText(txtFaMean.Text)
            };

            if (repository.Insert(word))
                MessageBox.Show("Insert Succeed", "Message");
            else
                MessageBox.Show("Something went wrong", "Message");
            BindGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = repository.GetWord(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
            if (MessageBox.Show($"Are you sure to delete {selected.WordFace}?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                if (repository.Delete(selected.WordID))
                    MessageBox.Show("Delete Succeed", "Message");
                else
                    MessageBox.Show("Something went wrong", "Message");
            }
            BindGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selected = repository.GetWord(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));

            if (repository.Update(selected, $"0|{NormalText(txtFace.Text)}|{NormalText(txtEnMean.Text)}|{NormalText(txtFaMean.Text)}|"))
                MessageBox.Show("Edit Succeed", "Message");
            else
                MessageBox.Show("Something went wrong", "Message");
            BindGrid();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selected = repository.GetWord(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                txtFace.Text = selected.WordFace;
                txtEnMean.Text = selected.WordEnglishMean;
                txtFaMean.Text = selected.WordPersianMean;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            repository.Save();
            repository = new Repository(Application.StartupPath + "Data.svg");
            BindGrid();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            repository = new Repository(Application.StartupPath + "Data.svg");
            BindGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnMean.Text = txtFace.Text = txtFaMean.Text = "";
        }

        private void dgvMainPage_DoubleClick(object sender, EventArgs e)
        {
            var dgv = dataGridView1;
            if (dgv.CurrentRow != null)
            {
                Word selected = repository.GetWord(Convert.ToInt16(dgv.CurrentRow.Cells[0].Value));
                Details frmDetails = new Details();

                frmDetails.LocalWord = new Word();
                frmDetails.LocalWord = selected;

                frmDetails.ShowDialog();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' /*enter*/)
            {
                var queryArray = txtQuery.Text;
                var temp = repository
                    .GetAllWords()
                    .Where(w => w.WordFace.Contains(queryArray) || w.WordEnglishMean.Contains(queryArray) || w.WordPersianMean.Contains(queryArray));
                BindGrid(temp);
            }
        }
    }
}
