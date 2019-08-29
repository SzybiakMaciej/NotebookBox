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
    public partial class SendForm : Form
    {
       
        public SendForm()
        {
         
            InitializeComponent();
        }
        public string FileName
        {
            get
            {
                return _fileName.Text;
            }
        }
        public string FolderName
        {
            get
            {
                return _folderName.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(FileName) || string.IsNullOrEmpty(FolderName))
            {
                MessageBox.Show("Nie wypełniłeś pól!!","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error );
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();

        }
    }
}
