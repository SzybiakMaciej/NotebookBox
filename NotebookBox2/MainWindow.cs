using Dropbox.Api;
using Dropbox.Api.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NotebookBox2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void SplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private bool TryGetToken(out string token)
        {   
            if (File.Exists("Token.txt"))
            {
                token = File.ReadAllText("Token.txt");
                return true;
            }
            token = null;
            return false;
        }

        private void _podzielButton_Click(object sender, EventArgs e)
        {
            string podziel = string.Format("{0}\n-------------------------------------------------------------------------------------------------\n", _Text.Text);
            _Text.Text = podziel;
            _Text.SelectionStart = _Text.Text.Length;
        }

        private void _clearButton_Click(object sender, EventArgs e)
        {
            _Text.Text = string.Empty;
        }

        OpenFileDialog filedialog = new OpenFileDialog();
        
        private void _sendFileButton_Click(object sender, EventArgs e)
        {
            string token;
            string folderTextBox = _folderTextBox.TextBoxText;
            if (!TryGetToken(out token))
            {
                MessageBox.Show("Nie udało się pobrać tokena");
                return;
            }
            filedialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            filedialog.FilterIndex = 2;
            filedialog.RestoreDirectory = true;
            if (filedialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(folderTextBox))
                {
                    MessageBox.Show("Nie podałeś Nazwy Folderu !!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UploadFile(filedialog.FileName, folderTextBox, token);
                    MessageBox.Show("Wysłano", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        SaveFileDialog Savefiledialog = new SaveFileDialog();
        private void _saveButton_Click(object sender, EventArgs e)
        {
            
            Savefiledialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            Savefiledialog.FilterIndex = 2;
            Savefiledialog.RestoreDirectory = true;
            if (Savefiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(Savefiledialog.FileName, _Text.Text.Replace("\n", "\r\n"), Encoding.UTF8);
            }
        }

        private void _SendButton_Click(object sender, EventArgs e)
        {

            string token;
            if (!TryGetToken(out token))
            {
                MessageBox.Show("Nie udało się pobrać tokena");
                return;
            }
            
            SendForm form2 = new SendForm();
            if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string mynote = _Text.Text;
                string name_file = form2.FileName;
                string name_folder = form2.FolderName;
         

               Upload(name_folder, GetFileName(name_file), mynote, token);
                MessageBox.Show("Wysłano", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void _TokenButton_Click(object sender, EventArgs e)
        {
            TokenDialog form3 = new TokenDialog();
            if (form3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string Token = form3.TokenName;

                File.WriteAllText("Token.txt", Token);
            
            }


        }
        private string GetFileName(string name)
        {
            return string.Format("{0}{1}.txt", name, DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss"));
        }


        async Task Upload(string folder, string file, string content, string token_name)
        {
             try
            {
                using (var dbx = new DropboxClient(token_name))
                {
                    using (var mem = new MemoryStream(Encoding.UTF8.GetBytes(content)))
                    {
                        var updated = await dbx.Files.UploadAsync("/" + folder + "/" + file, WriteMode.Add.Instance, body: mem);
                    }
                }
            }
            catch (Exception e)
            {
                File.WriteAllText("Błąd.txt", e.ToString());
                MessageBox.Show("Wystąpił błąd podczas wysyłania pliku: " + e.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        async Task UploadFile(string file,string folderTextBox, string token_name)
        {
            try
            {
                using (var dbx = new DropboxClient(token_name))
                {
                    var fileinfo = new FileInfo(file);
                    using (var mem = new FileStream(file, FileMode.Open))
                    {
                        var updated = await dbx.Files.UploadAsync("/" + folderTextBox + "/" + fileinfo.Name, WriteMode.Add.Instance, body: mem);
                    }
                }
            }
            catch (Exception e)
            {
                File.WriteAllText("Błąd.txt", e.ToString());
                MessageBox.Show("Wystąpił błąd podczas wysyłania pliku: " + e.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ribbonOrbMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maciej Szybiak \n NotebookBox Wersja 2.0", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
