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

namespace TEET_App
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        public Word LocalWord;

        private void Details_Load(object sender, EventArgs e)
        {
            lblWord.Text = LocalWord.WordFace;
            lblEnglish.Text = LocalWord.WordEnglishMean;
            lblPersian.Text = LocalWord.WordPersianMean;
        }

        private void Details_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27) //esc
            {
                this.Close();
            }
        }
    }
}
