namespace TEET_App
{
    partial class ManageForm
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            en = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtFace = new System.Windows.Forms.TextBox();
            txtEnMean = new System.Windows.Forms.TextBox();
            txtFaMean = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnInsert = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Word, en, fa });
            dataGridView1.Location = new System.Drawing.Point(0, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(994, 512);
            dataGridView1.TabIndex = 0;
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Word
            // 
            Word.HeaderText = "Word";
            Word.Name = "Word";
            Word.ReadOnly = true;
            // 
            // en
            // 
            en.HeaderText = "English Mean";
            en.Name = "en";
            en.ReadOnly = true;
            // 
            // fa
            // 
            fa.HeaderText = "Persian Mean";
            fa.Name = "fa";
            fa.ReadOnly = true;
            // 
            // txtFace
            // 
            txtFace.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFace.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFace.Location = new System.Drawing.Point(147, 12);
            txtFace.Name = "txtFace";
            txtFace.Size = new System.Drawing.Size(211, 33);
            txtFace.TabIndex = 1;
            // 
            // txtEnMean
            // 
            txtEnMean.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtEnMean.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEnMean.Location = new System.Drawing.Point(147, 51);
            txtEnMean.Multiline = true;
            txtEnMean.Name = "txtEnMean";
            txtEnMean.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtEnMean.Size = new System.Drawing.Size(499, 57);
            txtEnMean.TabIndex = 2;
            // 
            // txtFaMean
            // 
            txtFaMean.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFaMean.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFaMean.Location = new System.Drawing.Point(147, 114);
            txtFaMean.Name = "txtFaMean";
            txtFaMean.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtFaMean.Size = new System.Drawing.Size(499, 33);
            txtFaMean.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(67, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 30);
            label1.TabIndex = 4;
            label1.Text = "Word :";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(8, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 30);
            label2.TabIndex = 5;
            label2.Text = "Mean in EN :";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 113);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(129, 30);
            label3.TabIndex = 6;
            label3.Text = "Mean in FA :";
            // 
            // btnInsert
            // 
            btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnInsert.Location = new System.Drawing.Point(12, 171);
            btnInsert.MaximumSize = new System.Drawing.Size(108, 48);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(90, 40);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(108, 171);
            btnDelete.MaximumSize = new System.Drawing.Size(108, 48);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(90, 40);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(204, 171);
            btnUpdate.MaximumSize = new System.Drawing.Size(108, 48);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(90, 40);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Edit";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(892, 171);
            btnSave.MaximumSize = new System.Drawing.Size(108, 48);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(90, 40);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClear.Location = new System.Drawing.Point(650, 148);
            btnClear.MaximumSize = new System.Drawing.Size(62, 31);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(51, 27);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ManageForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(994, 729);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFaMean);
            Controls.Add(txtEnMean);
            Controls.Add(txtFace);
            Controls.Add(dataGridView1);
            Name = "ManageForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ManageForm";
            Load += ManageForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFace;
        private System.Windows.Forms.TextBox txtEnMean;
        private System.Windows.Forms.TextBox txtFaMean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn en;
        private System.Windows.Forms.DataGridViewTextBoxColumn fa;
        private System.Windows.Forms.Button btnClear;
    }
}