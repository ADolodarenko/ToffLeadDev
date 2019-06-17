namespace ToffLeadDev
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxResponce = new System.Windows.Forms.TextBox();
            this.textBoxApiSecret = new System.Windows.Forms.TextBox();
            this.textBoxApiKey = new System.Windows.Forms.TextBox();
            this.textBoxAgentId = new System.Windows.Forms.TextBox();
            this.labelAgentId = new System.Windows.Forms.Label();
            this.labelApiKey = new System.Windows.Forms.Label();
            this.labelApiSecret = new System.Windows.Forms.Label();
            this.labelSourceFile = new System.Windows.Forms.Label();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(10, 48);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(29, 13);
            this.labelURL.TabIndex = 0;
            this.labelURL.Text = "URL";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxURL.Location = new System.Drawing.Point(69, 45);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(593, 20);
            this.textBoxURL.TabIndex = 2;
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Location = new System.Drawing.Point(668, 19);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(102, 125);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxResponce
            // 
            this.textBoxResponce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResponce.Location = new System.Drawing.Point(9, 175);
            this.textBoxResponce.Multiline = true;
            this.textBoxResponce.Name = "textBoxResponce";
            this.textBoxResponce.Size = new System.Drawing.Size(779, 263);
            this.textBoxResponce.TabIndex = 3;
            this.textBoxResponce.TabStop = false;
            // 
            // textBoxApiSecret
            // 
            this.textBoxApiSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxApiSecret.Location = new System.Drawing.Point(69, 124);
            this.textBoxApiSecret.Name = "textBoxApiSecret";
            this.textBoxApiSecret.PasswordChar = '*';
            this.textBoxApiSecret.Size = new System.Drawing.Size(593, 20);
            this.textBoxApiSecret.TabIndex = 5;
            // 
            // textBoxApiKey
            // 
            this.textBoxApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxApiKey.Location = new System.Drawing.Point(69, 98);
            this.textBoxApiKey.Name = "textBoxApiKey";
            this.textBoxApiKey.Size = new System.Drawing.Size(593, 20);
            this.textBoxApiKey.TabIndex = 4;
            // 
            // textBoxAgentId
            // 
            this.textBoxAgentId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAgentId.Location = new System.Drawing.Point(69, 72);
            this.textBoxAgentId.Name = "textBoxAgentId";
            this.textBoxAgentId.Size = new System.Drawing.Size(593, 20);
            this.textBoxAgentId.TabIndex = 3;
            // 
            // labelAgentId
            // 
            this.labelAgentId.AutoSize = true;
            this.labelAgentId.Location = new System.Drawing.Point(10, 75);
            this.labelAgentId.Name = "labelAgentId";
            this.labelAgentId.Size = new System.Drawing.Size(45, 13);
            this.labelAgentId.TabIndex = 0;
            this.labelAgentId.Text = "agent-id";
            // 
            // labelApiKey
            // 
            this.labelApiKey.AutoSize = true;
            this.labelApiKey.Location = new System.Drawing.Point(10, 101);
            this.labelApiKey.Name = "labelApiKey";
            this.labelApiKey.Size = new System.Drawing.Size(41, 13);
            this.labelApiKey.TabIndex = 0;
            this.labelApiKey.Text = "api-key";
            // 
            // labelApiSecret
            // 
            this.labelApiSecret.AutoSize = true;
            this.labelApiSecret.Location = new System.Drawing.Point(10, 127);
            this.labelApiSecret.Name = "labelApiSecret";
            this.labelApiSecret.Size = new System.Drawing.Size(53, 13);
            this.labelApiSecret.TabIndex = 0;
            this.labelApiSecret.Text = "api-secret";
            // 
            // labelSourceFile
            // 
            this.labelSourceFile.AutoSize = true;
            this.labelSourceFile.Location = new System.Drawing.Point(10, 22);
            this.labelSourceFile.Name = "labelSourceFile";
            this.labelSourceFile.Size = new System.Drawing.Size(57, 13);
            this.labelSourceFile.TabIndex = 5;
            this.labelSourceFile.Text = "Source file";
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSourceFile.Location = new System.Drawing.Point(69, 19);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.Size = new System.Drawing.Size(593, 20);
            this.textBoxSourceFile.TabIndex = 1;
            this.textBoxSourceFile.Resize += new System.EventHandler(this.textBoxSourceFile_Resize);
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxControls.Controls.Add(this.buttonSend);
            this.groupBoxControls.Controls.Add(this.textBoxSourceFile);
            this.groupBoxControls.Controls.Add(this.labelURL);
            this.groupBoxControls.Controls.Add(this.labelSourceFile);
            this.groupBoxControls.Controls.Add(this.labelAgentId);
            this.groupBoxControls.Controls.Add(this.textBoxAgentId);
            this.groupBoxControls.Controls.Add(this.labelApiKey);
            this.groupBoxControls.Controls.Add(this.textBoxApiKey);
            this.groupBoxControls.Controls.Add(this.labelApiSecret);
            this.groupBoxControls.Controls.Add(this.textBoxApiSecret);
            this.groupBoxControls.Controls.Add(this.textBoxURL);
            this.groupBoxControls.Location = new System.Drawing.Point(12, 6);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(776, 157);
            this.groupBoxControls.TabIndex = 0;
            this.groupBoxControls.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xls";
            this.openFileDialog.Filter = "XLS files|*.xls|XLSX files|*.xlsx";
            this.openFileDialog.InitialDirectory = ".";
            this.openFileDialog.Title = "Select a source file";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.textBoxResponce);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toff Lead Developer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxResponce;
        private System.Windows.Forms.TextBox textBoxApiSecret;
        private System.Windows.Forms.TextBox textBoxApiKey;
        private System.Windows.Forms.TextBox textBoxAgentId;
        private System.Windows.Forms.Label labelAgentId;
        private System.Windows.Forms.Label labelApiKey;
        private System.Windows.Forms.Label labelApiSecret;
        private System.Windows.Forms.Label labelSourceFile;
        private System.Windows.Forms.TextBox textBoxSourceFile;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

