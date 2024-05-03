namespace TEET_App
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            txtField = new System.Windows.Forms.TextBox();
            dgvMainPage = new System.Windows.Forms.DataGridView();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            face = new System.Windows.Forms.DataGridViewTextBoxColumn();
            en = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            btnRefresh = new System.Windows.Forms.Button();
            radioButtonEndWith = new System.Windows.Forms.RadioButton();
            radioButtonContains = new System.Windows.Forms.RadioButton();
            radioButtonStartWith = new System.Windows.Forms.RadioButton();
            btnSearchFA = new System.Windows.Forms.Button();
            btnSearchEN = new System.Windows.Forms.Button();
            btnSearchWord = new System.Windows.Forms.Button();
            tabPage2 = new System.Windows.Forms.TabPage();
            btnFileSplitter = new System.Windows.Forms.Button();
            btnSaveQry = new System.Windows.Forms.Button();
            btnImport = new System.Windows.Forms.Button();
            btnManage = new System.Windows.Forms.Button();
            toolTipInfo = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvMainPage).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // txtField
            // 
            txtField.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtField.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtField.Location = new System.Drawing.Point(11, 103);
            txtField.Name = "txtField";
            txtField.Size = new System.Drawing.Size(749, 36);
            txtField.TabIndex = 1;
            txtField.TextChanged += txtField_TextChanged;
            // 
            // dgvMainPage
            // 
            dgvMainPage.AllowUserToAddRows = false;
            dgvMainPage.AllowUserToDeleteRows = false;
            dgvMainPage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvMainPage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMainPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id, face, en, fa });
            dgvMainPage.Location = new System.Drawing.Point(0, 146);
            dgvMainPage.Name = "dgvMainPage";
            dgvMainPage.ReadOnly = true;
            dgvMainPage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMainPage.Size = new System.Drawing.Size(772, 390);
            dgvMainPage.TabIndex = 2;
            dgvMainPage.DoubleClick += dgvMainPage_DoubleClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // face
            // 
            face.HeaderText = "Word";
            face.Name = "face";
            face.ReadOnly = true;
            face.Width = 61;
            // 
            // en
            // 
            en.HeaderText = "English";
            en.Name = "en";
            en.ReadOnly = true;
            en.Width = 70;
            // 
            // fa
            // 
            fa.HeaderText = "Persian";
            fa.Name = "fa";
            fa.ReadOnly = true;
            fa.Width = 70;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(772, 102);
            tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRefresh);
            tabPage1.Controls.Add(radioButtonEndWith);
            tabPage1.Controls.Add(radioButtonContains);
            tabPage1.Controls.Add(radioButtonStartWith);
            tabPage1.Controls.Add(btnSearchFA);
            tabPage1.Controls.Add(btnSearchEN);
            tabPage1.Controls.Add(btnSearchWord);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(764, 74);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Search";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.BackgroundImage = Properties.Resources.thin_0141_rotate_back_revert_undo;
            btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnRefresh.Font = new System.Drawing.Font("Chomsky", 23.9999962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRefresh.Location = new System.Drawing.Point(264, -1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(82, 76);
            btnRefresh.TabIndex = 10;
            toolTipInfo.SetToolTip(btnRefresh, "Refresh App");
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // radioButtonEndWith
            // 
            radioButtonEndWith.AutoSize = true;
            radioButtonEndWith.Location = new System.Drawing.Point(365, 43);
            radioButtonEndWith.Name = "radioButtonEndWith";
            radioButtonEndWith.Size = new System.Drawing.Size(75, 19);
            radioButtonEndWith.TabIndex = 9;
            radioButtonEndWith.Text = "EndsWith";
            radioButtonEndWith.UseVisualStyleBackColor = true;
            // 
            // radioButtonContains
            // 
            radioButtonContains.AutoSize = true;
            radioButtonContains.Checked = true;
            radioButtonContains.Location = new System.Drawing.Point(365, 24);
            radioButtonContains.Name = "radioButtonContains";
            radioButtonContains.Size = new System.Drawing.Size(72, 19);
            radioButtonContains.TabIndex = 8;
            radioButtonContains.TabStop = true;
            radioButtonContains.Text = "Contains";
            radioButtonContains.UseVisualStyleBackColor = true;
            // 
            // radioButtonStartWith
            // 
            radioButtonStartWith.AutoSize = true;
            radioButtonStartWith.Location = new System.Drawing.Point(365, 4);
            radioButtonStartWith.Name = "radioButtonStartWith";
            radioButtonStartWith.Size = new System.Drawing.Size(79, 19);
            radioButtonStartWith.TabIndex = 7;
            radioButtonStartWith.Text = "StartsWith";
            radioButtonStartWith.UseVisualStyleBackColor = true;
            // 
            // btnSearchFA
            // 
            btnSearchFA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSearchFA.Font = new System.Drawing.Font("Chomsky", 23.9999962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSearchFA.Location = new System.Drawing.Point(176, -1);
            btnSearchFA.Name = "btnSearchFA";
            btnSearchFA.Size = new System.Drawing.Size(82, 76);
            btnSearchFA.TabIndex = 6;
            btnSearchFA.Text = "FA";
            toolTipInfo.SetToolTip(btnSearchFA, "Search Based on FA Mean");
            btnSearchFA.UseVisualStyleBackColor = true;
            btnSearchFA.Click += btnSearchFA_Click;
            // 
            // btnSearchEN
            // 
            btnSearchEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSearchEN.Font = new System.Drawing.Font("Chomsky", 26.2499962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSearchEN.Location = new System.Drawing.Point(88, -1);
            btnSearchEN.Name = "btnSearchEN";
            btnSearchEN.Size = new System.Drawing.Size(82, 76);
            btnSearchEN.TabIndex = 5;
            btnSearchEN.Text = "EN";
            toolTipInfo.SetToolTip(btnSearchEN, "Search Based on EN Mean");
            btnSearchEN.UseVisualStyleBackColor = true;
            btnSearchEN.Click += btnSearchEN_Click;
            // 
            // btnSearchWord
            // 
            btnSearchWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSearchWord.Font = new System.Drawing.Font("Chomsky", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSearchWord.Location = new System.Drawing.Point(0, -1);
            btnSearchWord.Name = "btnSearchWord";
            btnSearchWord.Size = new System.Drawing.Size(82, 76);
            btnSearchWord.TabIndex = 4;
            btnSearchWord.Text = "Word";
            toolTipInfo.SetToolTip(btnSearchWord, "Search Based on Word");
            btnSearchWord.UseVisualStyleBackColor = true;
            btnSearchWord.Click += btnSearchWord_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnFileSplitter);
            tabPage2.Controls.Add(btnSaveQry);
            tabPage2.Controls.Add(btnImport);
            tabPage2.Controls.Add(btnManage);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(764, 74);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Activity";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFileSplitter
            // 
            btnFileSplitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnFileSplitter.Location = new System.Drawing.Point(243, 1);
            btnFileSplitter.Name = "btnFileSplitter";
            btnFileSplitter.Size = new System.Drawing.Size(76, 71);
            btnFileSplitter.TabIndex = 5;
            btnFileSplitter.Text = "File Splitter";
            toolTipInfo.SetToolTip(btnFileSplitter, "Split imported text word by word to insert to the Database");
            btnFileSplitter.UseVisualStyleBackColor = true;
            btnFileSplitter.Click += btnFileSplitter_Click;
            // 
            // btnSaveQry
            // 
            btnSaveQry.BackgroundImage = Properties.Resources.thin_0336_disc_floppy_save_software;
            btnSaveQry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSaveQry.Location = new System.Drawing.Point(81, 1);
            btnSaveQry.Name = "btnSaveQry";
            btnSaveQry.Size = new System.Drawing.Size(76, 71);
            btnSaveQry.TabIndex = 5;
            toolTipInfo.SetToolTip(btnSaveQry, "Save current results on a TXT file");
            btnSaveQry.UseVisualStyleBackColor = true;
            btnSaveQry.Click += btnSaveQry_Click;
            // 
            // btnImport
            // 
            btnImport.BackgroundImage = Properties.Resources.thin_0151_plus_add_new;
            btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnImport.Location = new System.Drawing.Point(162, 1);
            btnImport.Name = "btnImport";
            btnImport.Size = new System.Drawing.Size(76, 71);
            btnImport.TabIndex = 4;
            toolTipInfo.SetToolTip(btnImport, "Add new file to Database");
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnManage
            // 
            btnManage.BackgroundImage = Properties.Resources.thin_0052_settings_gears_preferences_gearbox;
            btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnManage.Location = new System.Drawing.Point(0, 1);
            btnManage.Name = "btnManage";
            btnManage.Size = new System.Drawing.Size(76, 71);
            btnManage.TabIndex = 3;
            toolTipInfo.SetToolTip(btnManage, "Open manage form");
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // toolTipInfo
            // 
            toolTipInfo.AutoPopDelay = 5000;
            toolTipInfo.InitialDelay = 250;
            toolTipInfo.ReshowDelay = 100;
            toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(772, 536);
            Controls.Add(tabControl1);
            Controls.Add(dgvMainPage);
            Controls.Add(txtField);
            Name = "Main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Main";
            SizeChanged += Main_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)dgvMainPage).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.DataGridView dgvMainPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.Button btnSaveQry;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnSearchWord;
        private System.Windows.Forms.Button btnSearchEN;
        private System.Windows.Forms.Button btnSearchFA;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn face;
        private System.Windows.Forms.DataGridViewTextBoxColumn en;
        private System.Windows.Forms.DataGridViewTextBoxColumn fa;
        private System.Windows.Forms.RadioButton radioButtonEndWith;
        private System.Windows.Forms.RadioButton radioButtonContains;
        private System.Windows.Forms.RadioButton radioButtonStartWith;
        private System.Windows.Forms.Button btnFileSplitter;
    }
}