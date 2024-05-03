namespace TEET_App
{
    partial class Details
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
            lblWord = new System.Windows.Forms.Label();
            lblEnglish = new System.Windows.Forms.Label();
            lblPersian = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblWord
            // 
            lblWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblWord.Dock = System.Windows.Forms.DockStyle.Top;
            lblWord.Font = new System.Drawing.Font("Berlin Sans FB", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblWord.Location = new System.Drawing.Point(0, 0);
            lblWord.Name = "lblWord";
            lblWord.Size = new System.Drawing.Size(856, 108);
            lblWord.TabIndex = 0;
            lblWord.Text = "Word";
            lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnglish
            // 
            lblEnglish.Dock = System.Windows.Forms.DockStyle.Top;
            lblEnglish.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEnglish.Location = new System.Drawing.Point(0, 108);
            lblEnglish.Name = "lblEnglish";
            lblEnglish.Size = new System.Drawing.Size(856, 211);
            lblEnglish.TabIndex = 1;
            lblEnglish.Text = "English";
            lblEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPersian
            // 
            lblPersian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblPersian.Dock = System.Windows.Forms.DockStyle.Top;
            lblPersian.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPersian.Location = new System.Drawing.Point(0, 319);
            lblPersian.Name = "lblPersian";
            lblPersian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblPersian.Size = new System.Drawing.Size(856, 114);
            lblPersian.TabIndex = 2;
            lblPersian.Text = "فارسی";
            lblPersian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Details
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(856, 454);
            Controls.Add(lblPersian);
            Controls.Add(lblEnglish);
            Controls.Add(lblWord);
            KeyPreview = true;
            Name = "Details";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Details";
            Load += Details_Load;
            KeyPress += Details_KeyPress;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblPersian;
    }
}