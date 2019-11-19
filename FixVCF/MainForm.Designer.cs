namespace FixVCF
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialogLoadSelector = new System.Windows.Forms.OpenFileDialog();
            this.textBoxLoadFullPath = new System.Windows.Forms.TextBox();
            this.buttonLoadSelectorOpen = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.textBoxSaveFullPath = new System.Windows.Forms.TextBox();
            this.saveFileDialogSelector = new System.Windows.Forms.SaveFileDialog();
            this.progressBarProcess = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // openFileDialogLoadSelector
            // 
            this.openFileDialogLoadSelector.FileName = "openFileDialog1";
            this.openFileDialogLoadSelector.Filter = "VCF files|*.vcf";
            // 
            // textBoxLoadFullPath
            // 
            this.textBoxLoadFullPath.Location = new System.Drawing.Point(12, 12);
            this.textBoxLoadFullPath.Name = "textBoxLoadFullPath";
            this.textBoxLoadFullPath.Size = new System.Drawing.Size(201, 20);
            this.textBoxLoadFullPath.TabIndex = 0;
            this.textBoxLoadFullPath.DoubleClick += new System.EventHandler(this.TextBoxLoadFullPath_DoubleClick);
            // 
            // buttonLoadSelectorOpen
            // 
            this.buttonLoadSelectorOpen.Enabled = false;
            this.buttonLoadSelectorOpen.Location = new System.Drawing.Point(219, 10);
            this.buttonLoadSelectorOpen.Name = "buttonLoadSelectorOpen";
            this.buttonLoadSelectorOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadSelectorOpen.TabIndex = 1;
            this.buttonLoadSelectorOpen.Text = "Look For";
            this.buttonLoadSelectorOpen.UseVisualStyleBackColor = true;
            this.buttonLoadSelectorOpen.Click += new System.EventHandler(this.ButtonLoadSelectorOpen_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Enabled = false;
            this.buttonProcess.Location = new System.Drawing.Point(219, 53);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonProcess.TabIndex = 2;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.ButtonProcess_Click);
            // 
            // textBoxSaveFullPath
            // 
            this.textBoxSaveFullPath.Location = new System.Drawing.Point(12, 53);
            this.textBoxSaveFullPath.Name = "textBoxSaveFullPath";
            this.textBoxSaveFullPath.Size = new System.Drawing.Size(201, 20);
            this.textBoxSaveFullPath.TabIndex = 3;
            this.textBoxSaveFullPath.DoubleClick += new System.EventHandler(this.TextBoxSaveFullPath_DoubleClick);
            // 
            // saveFileDialogSelector
            // 
            this.saveFileDialogSelector.DefaultExt = "vcf";
            this.saveFileDialogSelector.Filter = "VCF files|*.vcf";
            // 
            // progressBarProcess
            // 
            this.progressBarProcess.Location = new System.Drawing.Point(13, 95);
            this.progressBarProcess.Name = "progressBarProcess";
            this.progressBarProcess.Size = new System.Drawing.Size(200, 23);
            this.progressBarProcess.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 161);
            this.Controls.Add(this.progressBarProcess);
            this.Controls.Add(this.textBoxSaveFullPath);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonLoadSelectorOpen);
            this.Controls.Add(this.textBoxLoadFullPath);
            this.Name = "MainForm";
            this.Text = "ProtonMail to LineageOS vcf fixer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogLoadSelector;
        private System.Windows.Forms.TextBox textBoxLoadFullPath;
        private System.Windows.Forms.Button buttonLoadSelectorOpen;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.TextBox textBoxSaveFullPath;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSelector;
        private System.Windows.Forms.ProgressBar progressBarProcess;
    }
}

