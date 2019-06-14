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
            this.SuspendLayout();
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(12, 17);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(29, 13);
            this.labelURL.TabIndex = 0;
            this.labelURL.Text = "URL";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(71, 14);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(609, 20);
            this.textBoxURL.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(686, 12);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(102, 101);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxResponce
            // 
            this.textBoxResponce.Location = new System.Drawing.Point(15, 143);
            this.textBoxResponce.Multiline = true;
            this.textBoxResponce.Name = "textBoxResponce";
            this.textBoxResponce.Size = new System.Drawing.Size(773, 295);
            this.textBoxResponce.TabIndex = 3;
            // 
            // textBoxApiSecret
            // 
            this.textBoxApiSecret.Location = new System.Drawing.Point(71, 93);
            this.textBoxApiSecret.Name = "textBoxApiSecret";
            this.textBoxApiSecret.PasswordChar = '*';
            this.textBoxApiSecret.Size = new System.Drawing.Size(609, 20);
            this.textBoxApiSecret.TabIndex = 4;
            // 
            // textBoxApiKey
            // 
            this.textBoxApiKey.Location = new System.Drawing.Point(71, 67);
            this.textBoxApiKey.Name = "textBoxApiKey";
            this.textBoxApiKey.Size = new System.Drawing.Size(609, 20);
            this.textBoxApiKey.TabIndex = 4;
            // 
            // textBoxAgentId
            // 
            this.textBoxAgentId.Location = new System.Drawing.Point(71, 41);
            this.textBoxAgentId.Name = "textBoxAgentId";
            this.textBoxAgentId.Size = new System.Drawing.Size(609, 20);
            this.textBoxAgentId.TabIndex = 4;
            // 
            // labelAgentId
            // 
            this.labelAgentId.AutoSize = true;
            this.labelAgentId.Location = new System.Drawing.Point(12, 44);
            this.labelAgentId.Name = "labelAgentId";
            this.labelAgentId.Size = new System.Drawing.Size(45, 13);
            this.labelAgentId.TabIndex = 0;
            this.labelAgentId.Text = "agent-id";
            // 
            // labelApiKey
            // 
            this.labelApiKey.AutoSize = true;
            this.labelApiKey.Location = new System.Drawing.Point(12, 70);
            this.labelApiKey.Name = "labelApiKey";
            this.labelApiKey.Size = new System.Drawing.Size(41, 13);
            this.labelApiKey.TabIndex = 0;
            this.labelApiKey.Text = "api-key";
            // 
            // labelApiSecret
            // 
            this.labelApiSecret.AutoSize = true;
            this.labelApiSecret.Location = new System.Drawing.Point(12, 96);
            this.labelApiSecret.Name = "labelApiSecret";
            this.labelApiSecret.Size = new System.Drawing.Size(53, 13);
            this.labelApiSecret.TabIndex = 0;
            this.labelApiSecret.Text = "api-secret";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAgentId);
            this.Controls.Add(this.textBoxApiKey);
            this.Controls.Add(this.textBoxApiSecret);
            this.Controls.Add(this.textBoxResponce);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.labelApiSecret);
            this.Controls.Add(this.labelApiKey);
            this.Controls.Add(this.labelAgentId);
            this.Controls.Add(this.labelURL);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toff Lead Developer";
            this.Load += new System.EventHandler(this.FormMain_Load);
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
    }
}

