using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookBox2
{
    public partial class TokenDialog : Form
    {
        public TokenDialog()
        {
            InitializeComponent();
        }
        public string TokenName
        {
            get
            {
                return _tokenName.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TokenName))
            {
                MessageBox.Show("Nie podałeś tokenu!!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
