namespace WindowsFormsApplication1
{
    partial class WordExcelPdf
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
            this.ButWord = new System.Windows.Forms.Button();
            this.ButExc = new System.Windows.Forms.Button();
            this.ButPDF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButWord
            // 
            this.ButWord.Location = new System.Drawing.Point(67, 32);
            this.ButWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButWord.Name = "ButWord";
            this.ButWord.Size = new System.Drawing.Size(179, 28);
            this.ButWord.TabIndex = 0;
            this.ButWord.Text = "Отчет Word";
            this.ButWord.UseVisualStyleBackColor = true;
            this.ButWord.Click += new System.EventHandler(this.ButWord_Click);
            // 
            // ButExc
            // 
            this.ButExc.Location = new System.Drawing.Point(67, 86);
            this.ButExc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButExc.Name = "ButExc";
            this.ButExc.Size = new System.Drawing.Size(179, 28);
            this.ButExc.TabIndex = 1;
            this.ButExc.Text = "Отчет Excel";
            this.ButExc.UseVisualStyleBackColor = true;
            this.ButExc.Click += new System.EventHandler(this.ButExc_Click);
            // 
            // ButPDF
            // 
            this.ButPDF.Location = new System.Drawing.Point(67, 130);
            this.ButPDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButPDF.Name = "ButPDF";
            this.ButPDF.Size = new System.Drawing.Size(179, 28);
            this.ButPDF.TabIndex = 2;
            this.ButPDF.Text = "Отчет PDF";
            this.ButPDF.UseVisualStyleBackColor = true;
            this.ButPDF.Click += new System.EventHandler(this.ButPDF_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // WordExcelPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 229);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButPDF);
            this.Controls.Add(this.ButExc);
            this.Controls.Add(this.ButWord);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WordExcelPdf";
            this.ShowIcon = false;
            this.Text = "Документы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WordExcelPdf_FormClosed);
            this.Load += new System.EventHandler(this.WordExcelPdf_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButWord;
        private System.Windows.Forms.Button ButExc;
        private System.Windows.Forms.Button ButPDF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}