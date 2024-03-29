﻿namespace WindowsFormsApplication1
{
    partial class ConnectionForm
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
            this.cbDataSource = new System.Windows.Forms.ComboBox();
            this.cbInitialCatalog = new System.Windows.Forms.ComboBox();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lblServers = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.statusConect = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusConect.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDataSource
            // 
            this.cbDataSource.Enabled = false;
            this.cbDataSource.FormattingEnabled = true;
            this.cbDataSource.Location = new System.Drawing.Point(12, 38);
            this.cbDataSource.Name = "cbDataSource";
            this.cbDataSource.Size = new System.Drawing.Size(291, 21);
            this.cbDataSource.TabIndex = 0;
            // 
            // cbInitialCatalog
            // 
            this.cbInitialCatalog.Enabled = false;
            this.cbInitialCatalog.FormattingEnabled = true;
            this.cbInitialCatalog.Location = new System.Drawing.Point(12, 178);
            this.cbInitialCatalog.Name = "cbInitialCatalog";
            this.cbInitialCatalog.Size = new System.Drawing.Size(291, 21);
            this.cbInitialCatalog.TabIndex = 1;
            // 
            // tbUserID
            // 
            this.tbUserID.Enabled = false;
            this.tbUserID.Location = new System.Drawing.Point(12, 89);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(291, 20);
            this.tbUserID.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(12, 134);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(291, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // btCheck
            // 
            this.btCheck.Enabled = false;
            this.btCheck.Location = new System.Drawing.Point(12, 212);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(83, 21);
            this.btCheck.TabIndex = 4;
            this.btCheck.Text = "Проверка";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // btConnect
            // 
            this.btConnect.Enabled = false;
            this.btConnect.Location = new System.Drawing.Point(113, 212);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(92, 23);
            this.btConnect.TabIndex = 5;
            this.btConnect.Text = "Подключить";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btCancel
            // 
            this.btCancel.Enabled = false;
            this.btCancel.Location = new System.Drawing.Point(228, 212);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lblServers
            // 
            this.lblServers.AutoSize = true;
            this.lblServers.Location = new System.Drawing.Point(12, 22);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(98, 13);
            this.lblServers.TabIndex = 7;
            this.lblServers.Text = "Список серверов:";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(12, 73);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(128, 13);
            this.lblUsers.TabIndex = 8;
            this.lblUsers.Text = "Пользователь сервера:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 118);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(122, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Пароль пользователя:";
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Location = new System.Drawing.Point(12, 162);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(148, 13);
            this.lblDataSource.TabIndex = 10;
            this.lblDataSource.Text = "Список источников данных:";
            // 
            // statusConect
            // 
            this.statusConect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusConect.Location = new System.Drawing.Point(0, 235);
            this.statusConect.Name = "statusConect";
            this.statusConect.Size = new System.Drawing.Size(309, 22);
            this.statusConect.TabIndex = 11;
            this.statusConect.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(12, 17);
            this.tsslStatus.Text = "-";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 257);
            this.Controls.Add(this.statusConect);
            this.Controls.Add(this.lblDataSource);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblServers);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.cbInitialCatalog);
            this.Controls.Add(this.cbDataSource);
            this.Name = "ConnectionForm";
            this.ShowIcon = false;
            this.Text = "Настройка подключения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionForm_FormClosing);
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.statusConect.ResumeLayout(false);
            this.statusConect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDataSource;
        private System.Windows.Forms.ComboBox cbInitialCatalog;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lblServers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.StatusStrip statusConect;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
    }
}