namespace ToffLeadDev
{
    partial class FormSettings
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
            this.groupBoxValues = new System.Windows.Forms.GroupBox();
            this.groupBoxCommand = new System.Windows.Forms.GroupBox();
            this.textBoxMainTitle = new System.Windows.Forms.TextBox();
            this.textBoxApiUrl = new System.Windows.Forms.TextBox();
            this.textBoxPhonePrefix = new System.Windows.Forms.TextBox();
            this.textBoxLeadSource = new System.Windows.Forms.TextBox();
            this.textBoxLeadSubsource = new System.Windows.Forms.TextBox();
            this.textBoxLeadProduct = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMainTitle = new System.Windows.Forms.Label();
            this.labelApiUrl = new System.Windows.Forms.Label();
            this.labelPhonePrefix = new System.Windows.Forms.Label();
            this.labelLeadProduct = new System.Windows.Forms.Label();
            this.labelLeadSource = new System.Windows.Forms.Label();
            this.labelLeadSubsource = new System.Windows.Forms.Label();
            this.textBoxLeadTemperature = new System.Windows.Forms.TextBox();
            this.labelLeadTemperature = new System.Windows.Forms.Label();
            this.checkBoxLeadIsHot = new System.Windows.Forms.CheckBox();
            this.labelLeadIsHot = new System.Windows.Forms.Label();
            this.groupBoxValues.SuspendLayout();
            this.groupBoxCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxValues
            // 
            this.groupBoxValues.Controls.Add(this.labelLeadIsHot);
            this.groupBoxValues.Controls.Add(this.checkBoxLeadIsHot);
            this.groupBoxValues.Controls.Add(this.labelLeadTemperature);
            this.groupBoxValues.Controls.Add(this.labelLeadSubsource);
            this.groupBoxValues.Controls.Add(this.labelLeadSource);
            this.groupBoxValues.Controls.Add(this.labelLeadProduct);
            this.groupBoxValues.Controls.Add(this.labelPhonePrefix);
            this.groupBoxValues.Controls.Add(this.labelApiUrl);
            this.groupBoxValues.Controls.Add(this.labelMainTitle);
            this.groupBoxValues.Controls.Add(this.textBoxLeadProduct);
            this.groupBoxValues.Controls.Add(this.textBoxLeadSource);
            this.groupBoxValues.Controls.Add(this.textBoxLeadTemperature);
            this.groupBoxValues.Controls.Add(this.textBoxLeadSubsource);
            this.groupBoxValues.Controls.Add(this.textBoxPhonePrefix);
            this.groupBoxValues.Controls.Add(this.textBoxApiUrl);
            this.groupBoxValues.Controls.Add(this.textBoxMainTitle);
            this.groupBoxValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxValues.Location = new System.Drawing.Point(0, 0);
            this.groupBoxValues.Name = "groupBoxValues";
            this.groupBoxValues.Size = new System.Drawing.Size(524, 291);
            this.groupBoxValues.TabIndex = 0;
            this.groupBoxValues.TabStop = false;
            // 
            // groupBoxCommand
            // 
            this.groupBoxCommand.Controls.Add(this.buttonCancel);
            this.groupBoxCommand.Controls.Add(this.buttonSave);
            this.groupBoxCommand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxCommand.Location = new System.Drawing.Point(0, 241);
            this.groupBoxCommand.Name = "groupBoxCommand";
            this.groupBoxCommand.Size = new System.Drawing.Size(524, 50);
            this.groupBoxCommand.TabIndex = 1;
            this.groupBoxCommand.TabStop = false;
            // 
            // textBoxMainTitle
            // 
            this.textBoxMainTitle.Location = new System.Drawing.Point(135, 19);
            this.textBoxMainTitle.Name = "textBoxMainTitle";
            this.textBoxMainTitle.Size = new System.Drawing.Size(375, 20);
            this.textBoxMainTitle.TabIndex = 0;
            // 
            // textBoxApiUrl
            // 
            this.textBoxApiUrl.Location = new System.Drawing.Point(135, 45);
            this.textBoxApiUrl.Name = "textBoxApiUrl";
            this.textBoxApiUrl.Size = new System.Drawing.Size(375, 20);
            this.textBoxApiUrl.TabIndex = 1;
            // 
            // textBoxPhonePrefix
            // 
            this.textBoxPhonePrefix.Location = new System.Drawing.Point(135, 71);
            this.textBoxPhonePrefix.Name = "textBoxPhonePrefix";
            this.textBoxPhonePrefix.Size = new System.Drawing.Size(375, 20);
            this.textBoxPhonePrefix.TabIndex = 2;
            // 
            // textBoxLeadSource
            // 
            this.textBoxLeadSource.Location = new System.Drawing.Point(135, 123);
            this.textBoxLeadSource.Name = "textBoxLeadSource";
            this.textBoxLeadSource.Size = new System.Drawing.Size(375, 20);
            this.textBoxLeadSource.TabIndex = 4;
            // 
            // textBoxLeadSubsource
            // 
            this.textBoxLeadSubsource.Location = new System.Drawing.Point(135, 149);
            this.textBoxLeadSubsource.Name = "textBoxLeadSubsource";
            this.textBoxLeadSubsource.Size = new System.Drawing.Size(375, 20);
            this.textBoxLeadSubsource.TabIndex = 5;
            // 
            // textBoxLeadProduct
            // 
            this.textBoxLeadProduct.Location = new System.Drawing.Point(135, 97);
            this.textBoxLeadProduct.Name = "textBoxLeadProduct";
            this.textBoxLeadProduct.Size = new System.Drawing.Size(375, 20);
            this.textBoxLeadProduct.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(174, 19);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(274, 19);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.Location = new System.Drawing.Point(12, 22);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(108, 13);
            this.labelMainTitle.TabIndex = 1;
            this.labelMainTitle.Text = "Main Application Title";
            // 
            // labelApiUrl
            // 
            this.labelApiUrl.AutoSize = true;
            this.labelApiUrl.Location = new System.Drawing.Point(12, 48);
            this.labelApiUrl.Name = "labelApiUrl";
            this.labelApiUrl.Size = new System.Drawing.Size(86, 13);
            this.labelApiUrl.TabIndex = 1;
            this.labelApiUrl.Text = "Default API URL";
            // 
            // labelPhonePrefix
            // 
            this.labelPhonePrefix.AutoSize = true;
            this.labelPhonePrefix.Location = new System.Drawing.Point(12, 74);
            this.labelPhonePrefix.Name = "labelPhonePrefix";
            this.labelPhonePrefix.Size = new System.Drawing.Size(66, 13);
            this.labelPhonePrefix.TabIndex = 1;
            this.labelPhonePrefix.Text = "Phone prefix";
            // 
            // labelLeadProduct
            // 
            this.labelLeadProduct.AutoSize = true;
            this.labelLeadProduct.Location = new System.Drawing.Point(12, 100);
            this.labelLeadProduct.Name = "labelLeadProduct";
            this.labelLeadProduct.Size = new System.Drawing.Size(94, 13);
            this.labelLeadProduct.TabIndex = 1;
            this.labelLeadProduct.Text = "API: Lead Product";
            // 
            // labelLeadSource
            // 
            this.labelLeadSource.AutoSize = true;
            this.labelLeadSource.Location = new System.Drawing.Point(12, 126);
            this.labelLeadSource.Name = "labelLeadSource";
            this.labelLeadSource.Size = new System.Drawing.Size(91, 13);
            this.labelLeadSource.TabIndex = 1;
            this.labelLeadSource.Text = "API: Lead Source";
            // 
            // labelLeadSubsource
            // 
            this.labelLeadSubsource.AutoSize = true;
            this.labelLeadSubsource.Location = new System.Drawing.Point(12, 152);
            this.labelLeadSubsource.Name = "labelLeadSubsource";
            this.labelLeadSubsource.Size = new System.Drawing.Size(108, 13);
            this.labelLeadSubsource.TabIndex = 1;
            this.labelLeadSubsource.Text = "API: Lead Subsource";
            // 
            // textBoxLeadTemperature
            // 
            this.textBoxLeadTemperature.Location = new System.Drawing.Point(135, 175);
            this.textBoxLeadTemperature.Name = "textBoxLeadTemperature";
            this.textBoxLeadTemperature.Size = new System.Drawing.Size(375, 20);
            this.textBoxLeadTemperature.TabIndex = 6;
            // 
            // labelLeadTemperature
            // 
            this.labelLeadTemperature.AutoSize = true;
            this.labelLeadTemperature.Location = new System.Drawing.Point(12, 178);
            this.labelLeadTemperature.Name = "labelLeadTemperature";
            this.labelLeadTemperature.Size = new System.Drawing.Size(117, 13);
            this.labelLeadTemperature.TabIndex = 1;
            this.labelLeadTemperature.Text = "API: Lead Temperature";
            // 
            // checkBoxLeadIsHot
            // 
            this.checkBoxLeadIsHot.AutoSize = true;
            this.checkBoxLeadIsHot.Location = new System.Drawing.Point(135, 201);
            this.checkBoxLeadIsHot.Name = "checkBoxLeadIsHot";
            this.checkBoxLeadIsHot.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLeadIsHot.TabIndex = 7;
            this.checkBoxLeadIsHot.UseVisualStyleBackColor = true;
            // 
            // labelLeadIsHot
            // 
            this.labelLeadIsHot.AutoSize = true;
            this.labelLeadIsHot.Location = new System.Drawing.Point(12, 202);
            this.labelLeadIsHot.Name = "labelLeadIsHot";
            this.labelLeadIsHot.Size = new System.Drawing.Size(85, 13);
            this.labelLeadIsHot.TabIndex = 3;
            this.labelLeadIsHot.Text = "API: Lead Is Hot";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 291);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxCommand);
            this.Controls.Add(this.groupBoxValues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBoxValues.ResumeLayout(false);
            this.groupBoxValues.PerformLayout();
            this.groupBoxCommand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxValues;
        private System.Windows.Forms.TextBox textBoxLeadProduct;
        private System.Windows.Forms.TextBox textBoxLeadSource;
        private System.Windows.Forms.TextBox textBoxLeadSubsource;
        private System.Windows.Forms.TextBox textBoxPhonePrefix;
        private System.Windows.Forms.TextBox textBoxApiUrl;
        private System.Windows.Forms.TextBox textBoxMainTitle;
        private System.Windows.Forms.GroupBox groupBoxCommand;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelLeadSource;
        private System.Windows.Forms.Label labelLeadProduct;
        private System.Windows.Forms.Label labelPhonePrefix;
        private System.Windows.Forms.Label labelApiUrl;
        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.Label labelLeadTemperature;
        private System.Windows.Forms.Label labelLeadSubsource;
        private System.Windows.Forms.TextBox textBoxLeadTemperature;
        private System.Windows.Forms.Label labelLeadIsHot;
        private System.Windows.Forms.CheckBox checkBoxLeadIsHot;
    }
}