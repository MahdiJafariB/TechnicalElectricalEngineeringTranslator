using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Windows.Forms;
using TEET_Data;
using TEET_Data.Repository;
using Utility;

namespace TEET_App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            words = repository.GetAllWords();
        }

        Repository repository = new Repository(Application.StartupPath + "Data.svg");
        List<Word> words;

        IEnumerable<Word> Query(string propertyName)
        {
            string txtBox = txtField.Text.ToLower();

            var t = typeof(Word).GetProperties().Where(x => x.Name == propertyName).First();
            // ?? throw new Exception("propertyName does not exist in the Word datatype.");

            var temp1 = from word in words
                        where radioButtonStartWith.Checked
                        && t.GetValue(word).ToString().ToLower().StartsWith(txtBox)
                        select word;
            temp1 = temp1.Any() ? temp1 : null;

            var temp2 = from word in words
                        where radioButtonContains.Checked
                        && t.GetValue(word).ToString().ToLower().Contains(txtBox)
                        select word;
            temp2 = temp2.Any() ? temp2 : null;

            var temp3 = from word in words
                        where radioButtonEndWith.Checked
                        && t.GetValue(word).ToString().ToLower().EndsWith(txtBox)
                        select word;
            temp3 = temp3.Any() ? temp3 : null;

            return temp1 ?? temp2 ?? temp3 ?? new List<Word>();
        }

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
            var t = Query("WordFace").ToList(); // 14 milisecond
            BindGrid(t);
        }

        private void btnSearchEN_Click(object sender, EventArgs e)
        {
            BindGrid(Query("WordEnglishMean"));
            //IEnumerable<Word> qry;
            //if (radioButtonStartWith.Checked)
            //{
            //    qry = words.Where(w => w.WordEnglishMean.ToLower().StartsWith(txtField.Text));
            //}
            //else if (radioButtonContains.Checked)
            //{
            //    qry = words.Where(w => w.WordEnglishMean.ToLower().Contains(txtField.Text));
            //}
            //else
            //{
            //    qry = words.Where(w => w.WordEnglishMean.ToLower().EndsWith(txtField.Text));
            //}
            //BindGrid(qry);
        }

        private void btnSearchFA_Click(object sender, EventArgs e)
        {
            BindGrid(Query("WordPersianMean"));
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
            words = repository.GetAllWords();
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
