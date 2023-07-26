using System.Windows.Forms;

namespace TEET_App
{
    partial class SplitterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvInsert = new DataGridView();
            wordFace = new DataGridViewTextBoxColumn();
            enm = new DataGridViewTextBoxColumn();
            fam = new DataGridViewTextBoxColumn();
            insert = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInsert).BeginInit();
            SuspendLayout();
            // 
            // dgvInsert
            // 
            dgvInsert.AllowUserToAddRows = false;
            dgvInsert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvInsert.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            dgvInsert.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsert.Columns.AddRange(new DataGridViewColumn[] { wordFace, enm, fam, insert });
            dgvInsert.Dock = DockStyle.Fill;
            dgvInsert.Location = new System.Drawing.Point(0, 0);
            dgvInsert.Name = "dgvInsert";
            dgvInsert.RowTemplate.Height = 27;
            dgvInsert.Size = new System.Drawing.Size(800, 450);
            dgvInsert.TabIndex = 0;
            dgvInsert.CellClick += dgvInsert_CellClick;
            // 
            // wordFace
            // 
            wordFace.HeaderText = "Word";
            wordFace.Name = "wordFace";
            wordFace.Width = 65;
            // 
            // enm
            // 
            enm.HeaderText = "Mean in EN";
            enm.Name = "enm";
            enm.Width = 101;
            // 
            // fam
            // 
            fam.HeaderText = "Mean in FA";
            fam.Name = "fam";
            fam.Width = 97;
            // 
            // insert
            // 
            insert.HeaderText = "Insert";
            insert.Name = "insert";
            insert.Width = 46;
            // 
            // SplitterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvInsert);
            Name = "SplitterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Splitter Lab";
            Load += SplitterForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInsert).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInsert;
        private DataGridViewTextBoxColumn wordFace;
        private DataGridViewTextBoxColumn enm;
        private DataGridViewTextBoxColumn fam;
        private DataGridViewButtonColumn insert;
    }
}