namespace MassEmail
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxAdresy = new System.Windows.Forms.ListBox();
            this.buttonDodajAdres = new System.Windows.Forms.Button();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAdres);
            this.groupBox1.Controls.Add(this.buttonDodajAdres);
            this.groupBox1.Controls.Add(this.listBoxAdresy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista adresów:";
            // 
            // listBoxAdresy
            // 
            this.listBoxAdresy.FormattingEnabled = true;
            this.listBoxAdresy.Location = new System.Drawing.Point(6, 19);
            this.listBoxAdresy.Name = "listBoxAdresy";
            this.listBoxAdresy.Size = new System.Drawing.Size(208, 420);
            this.listBoxAdresy.TabIndex = 0;
            // 
            // buttonDodajAdres
            // 
            this.buttonDodajAdres.Location = new System.Drawing.Point(67, 471);
            this.buttonDodajAdres.Name = "buttonDodajAdres";
            this.buttonDodajAdres.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajAdres.TabIndex = 1;
            this.buttonDodajAdres.Text = "Dodaj";
            this.buttonDodajAdres.UseVisualStyleBackColor = true;
            this.buttonDodajAdres.Click += new System.EventHandler(this.buttonDodajAdres_Click);
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(6, 445);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(208, 20);
            this.textBoxAdres.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 525);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MD Masowa Poczta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxAdresy;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Button buttonDodajAdres;
    }
}

