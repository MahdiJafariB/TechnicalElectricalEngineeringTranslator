using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TEET_Data;
using TEET_Data.Repository;

namespace TEET_App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Repository repository = new Repository(Application.StartupPath + "Data.svg");

        void BindGrid(IEnumerable<Word> words)
        {
            if (!words.Any())
            {
                dgvMainPage.Rows.Clear();
                return;
            }
            dgvMainPage.Rows.Clear();
            foreach (var item in words)
            {
                dgvMainPage.Rows.Add(item.WordID, item.WordFace, item.WordEnglishMean, item.WordPersianMean);
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();
            manageForm.ShowDialog();
        }

        private void btnSearchWord_Click(object sender, EventArgs e)
        {
            IEnumerable<Word> qry;
            if (radioButtonStartWith.Checked)
            {
                qry = repository.GetAllWords().Where(w => w.WordFace.ToLower().StartsWith(txtField.Text));
            }
            else if (radioButtonContains.Checked)
            {
                qry = repository.GetAllWords().Where(w => w.WordFace.ToLower().Contains(txtField.Text));
            }
            else
            {
                qry = repository.GetAllWords().Where(w => w.WordFace.ToLower().EndsWith(txtField.Text));
            }
            BindGrid(qry);
        }

        private void btnSearchEN_Click(object sender, EventArgs e)
        {
            IEnumerable<Word> qry;
            if (radioButtonStartWith.Checked)
            {
                qry = repository.GetAllWords().Where(w => w.WordEnglishMean.ToLower().StartsWith(txtField.Text));
            }
            else if (radioButtonContains.Checked)
            {
                qry = repository.GetAllWords().Where(w => w.WordEnglishMean.ToLower().Contains(txtField.Text));
            }
            else
            {
                qry = repository.GetAllWords().Where(w => w.WordEnglishMean.ToLower().EndsWith(txtField.Text));
            }
            BindGrid(qry);
        }

        private void btnSearchFA_Click(object sender, EventArgs e)
        {
            IEnumerable<Word> qry;
            if (radioButtonStartWith.Checked)
            {
                qry = repository.GetAllWords().Where(w => w.WordPersianMean.ToLower().StartsWith(txtField.Text));
            }
            else if (radioButtonContains.Checked)
            {
                qry = repository.GetAllWords().Where(w => w.WordPersianMean.ToLower().Contains(txtField.Text));
            }
            else
            {
                qry = repository.GetAllWords().Where(w => w.WordPersianMean.ToLower().EndsWith(txtField.Text));
            }
            BindGrid(qry);
        }
        private void txtField_TextChanged(object sender, EventArgs e)
        {
            if (txtField.Text == "")
            {
                dgvMainPage.Rows.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            repository = new Repository(Application.StartupPath + "Data.svg");
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File|*.txt|SVG File|*.svg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var t = File.ReadAllLines(openFileDialog.FileName);
                var dt = t.Select(x => (Word)x);
                foreach (var w in dt)
                {
                    repository.Insert(w);
                }
                BindGrid(dt);
                if (MessageBox.Show("Do you want to save these on the Database?", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    repository.Save();
                }
            }
        }

        private void btnSaveQry_Click(object sender, EventArgs e)
        {
            List<string> words = new List<string>();
            foreach (DataGridViewRow row in dgvMainPage.Rows)
            {
                words.Add($"{row.Cells[0].Value}|{row.Cells[1].Value}|{row.Cells[2].Value}|{row.Cells[3].Value}");
            }
            if (dgvMainPage.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    File.WriteAllLines(saveFileDialog.FileName, words);
            }
        }

        private void btnFileSplitter_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File|*.txt|" +
                "SVG File|*.svg|" +
                "Word File|*.docx|" +
                "PDF|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var t = File.ReadAllText(openFileDialog.FileName);
                var dt = t.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                SplitterForm splitter = new SplitterForm();
                splitter.Bag = new List<string>(dt);
                splitter.ShowDialog();

                //if (MessageBox.Show("Do you want to save these on the Database?", "Message",
                //    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                //    == DialogResult.Yes)
                //{
                //    repository.Save();
                //}
            }
        }
    }
}
