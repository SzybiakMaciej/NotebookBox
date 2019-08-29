namespace NotebookBox2
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this._Text = new System.Windows.Forms.RichTextBox();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this._SendButton = new System.Windows.Forms.RibbonButton();
            this._saveButton = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this._sendFileButton = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this._clearButton = new System.Windows.Forms.RibbonButton();
            this._podzielButton = new System.Windows.Forms.RibbonButton();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this._TokenButton = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this._folderTextBox = new System.Windows.Forms.RibbonTextBox();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.SuspendLayout();
            // 
            // _Text
            // 
            this._Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._Text.Location = new System.Drawing.Point(13, 140);
            this._Text.Name = "_Text";
            this._Text.Size = new System.Drawing.Size(746, 467);
            this._Text.TabIndex = 1;
            this._Text.Text = "";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Text = "Nowy Plik";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreEnabled = false;
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this._SendButton);
            this.ribbonPanel1.Items.Add(this._saveButton);
            this.ribbonPanel1.Text = "Schowek";
            // 
            // _SendButton
            // 
            this._SendButton.Image = global::NotebookBox2.Properties.Resources.wyslij;
            this._SendButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("_SendButton.SmallImage")));
            this._SendButton.Text = "Wyślij";
            this._SendButton.Click += new System.EventHandler(this._SendButton_Click);
            // 
            // _saveButton
            // 
            this._saveButton.Image = global::NotebookBox2.Properties.Resources.floppy_disk_icon_22422;
            this._saveButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("_saveButton.SmallImage")));
            this._saveButton.Text = "Zapisz";
            this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ButtonMoreEnabled = false;
            this.ribbonPanel2.ButtonMoreVisible = false;
            this.ribbonPanel2.Items.Add(this._sendFileButton);
            this.ribbonPanel2.Text = "Plik";
            // 
            // _sendFileButton
            // 
            this._sendFileButton.Image = global::NotebookBox2.Properties.Resources.file_transfer_icons_57235;
            this._sendFileButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("_sendFileButton.SmallImage")));
            this._sendFileButton.Text = "Wyślij";
            this._sendFileButton.Click += new System.EventHandler(this._sendFileButton_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ButtonMoreEnabled = false;
            this.ribbonPanel3.ButtonMoreVisible = false;
            this.ribbonPanel3.Items.Add(this._clearButton);
            this.ribbonPanel3.Items.Add(this._podzielButton);
            this.ribbonPanel3.Text = "Tekst";
            // 
            // _clearButton
            // 
            this._clearButton.Image = global::NotebookBox2.Properties.Resources.eraser__1_;
            this._clearButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("_clearButton.SmallImage")));
            this._clearButton.Text = "Wyczyść";
            this._clearButton.Click += new System.EventHandler(this._clearButton_Click);
            // 
            // _podzielButton
            // 
            this._podzielButton.Image = global::NotebookBox2.Properties.Resources.clipping_text;
            this._podzielButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("_podzielButton.SmallImage")));
            this._podzielButton.Text = "Podziel";
            this._podzielButton.Click += new System.EventHandler(this._podzielButton_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Panels.Add(this.ribbonPanel4);
            this.ribbonTab2.Panels.Add(this.ribbonPanel5);
            this.ribbonTab2.Text = "Opcje";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ButtonMoreEnabled = false;
            this.ribbonPanel4.ButtonMoreVisible = false;
            this.ribbonPanel4.Items.Add(this._TokenButton);
            this.ribbonPanel4.Text = "Klucz";
            // 
            // _TokenButton
            // 
            this._TokenButton.Image = global::NotebookBox2.Properties.Resources.key_blue;
            this._TokenButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("_TokenButton.SmallImage")));
            this._TokenButton.Text = "Token";
            this._TokenButton.Click += new System.EventHandler(this._TokenButton_Click);
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ButtonMoreEnabled = false;
            this.ribbonPanel5.ButtonMoreVisible = false;
            this.ribbonPanel5.Items.Add(this._folderTextBox);
            this.ribbonPanel5.Text = "Wyślij Plik";
            // 
            // _folderTextBox
            // 
            this._folderTextBox.Text = "Nazwa Folderu";
            this._folderTextBox.TextBoxText = "";
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem2);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 119);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = global::NotebookBox2.Properties.Resources.untitled2;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(771, 134);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            this.ribbonOrbMenuItem2.Text = "Informacje";
            this.ribbonOrbMenuItem2.Click += new System.EventHandler(this.ribbonOrbMenuItem2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 619);
            this.Controls.Add(this._Text);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(771, 619);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotebookBox2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RichTextBox _Text;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton _SendButton;
        private System.Windows.Forms.RibbonButton _saveButton;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton _sendFileButton;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton _clearButton;
        private System.Windows.Forms.RibbonButton _podzielButton;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton _TokenButton;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;

        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem2;
        private System.Windows.Forms.RibbonOrbRecentItem ribbonOrbRecentItem1;

        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonTextBox _folderTextBox;
    }
}