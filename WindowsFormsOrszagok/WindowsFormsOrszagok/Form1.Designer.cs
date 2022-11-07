namespace WindowsFormsOrszagok
{
    partial class Form_Orszagok
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
            this.listBox_Orszagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Allamforma = new System.Windows.Forms.TextBox();
            this.textBox_Nepesseg = new System.Windows.Forms.TextBox();
            this.textBox_Terulet = new System.Windows.Forms.TextBox();
            this.textBox_Fovaros = new System.Windows.Forms.TextBox();
            this.textBox_OrszagNeve = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Orszagok
            // 
            this.listBox_Orszagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Orszagok.FormattingEnabled = true;
            this.listBox_Orszagok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Orszagok.Name = "listBox_Orszagok";
            this.listBox_Orszagok.Size = new System.Drawing.Size(141, 450);
            this.listBox_Orszagok.TabIndex = 0;
            this.listBox_Orszagok.SelectedIndexChanged += new System.EventHandler(this.listBox_Orszagok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Allamforma);
            this.groupBox1.Controls.Add(this.textBox_Nepesseg);
            this.groupBox1.Controls.Add(this.textBox_Terulet);
            this.groupBox1.Controls.Add(this.textBox_Fovaros);
            this.groupBox1.Controls.Add(this.textBox_OrszagNeve);
            this.groupBox1.Controls.Add(this.textBox_Id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(141, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott ország adatai";
            // 
            // textBox_Allamforma
            // 
            this.textBox_Allamforma.Location = new System.Drawing.Point(83, 199);
            this.textBox_Allamforma.Name = "textBox_Allamforma";
            this.textBox_Allamforma.Size = new System.Drawing.Size(158, 20);
            this.textBox_Allamforma.TabIndex = 11;
            // 
            // textBox_Nepesseg
            // 
            this.textBox_Nepesseg.Location = new System.Drawing.Point(83, 160);
            this.textBox_Nepesseg.Name = "textBox_Nepesseg";
            this.textBox_Nepesseg.Size = new System.Drawing.Size(158, 20);
            this.textBox_Nepesseg.TabIndex = 10;
            this.textBox_Nepesseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Terulet
            // 
            this.textBox_Terulet.Location = new System.Drawing.Point(83, 127);
            this.textBox_Terulet.Name = "textBox_Terulet";
            this.textBox_Terulet.Size = new System.Drawing.Size(158, 20);
            this.textBox_Terulet.TabIndex = 9;
            this.textBox_Terulet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Fovaros
            // 
            this.textBox_Fovaros.Location = new System.Drawing.Point(83, 90);
            this.textBox_Fovaros.Name = "textBox_Fovaros";
            this.textBox_Fovaros.Size = new System.Drawing.Size(158, 20);
            this.textBox_Fovaros.TabIndex = 8;
            // 
            // textBox_OrszagNeve
            // 
            this.textBox_OrszagNeve.Location = new System.Drawing.Point(83, 55);
            this.textBox_OrszagNeve.Name = "textBox_OrszagNeve";
            this.textBox_OrszagNeve.Size = new System.Drawing.Size(158, 20);
            this.textBox_OrszagNeve.TabIndex = 7;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(83, 23);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(158, 20);
            this.textBox_Id.TabIndex = 6;
            this.textBox_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Államforma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Népesség:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Terület:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Főváros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ország neve:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id: ";
            // 
            // Form_Orszagok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Orszagok);
            this.Name = "Form_Orszagok";
            this.Text = "A Föld országai";
            this.Load += new System.EventHandler(this.Form_Orszagok_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Orszagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Allamforma;
        private System.Windows.Forms.TextBox textBox_Nepesseg;
        private System.Windows.Forms.TextBox textBox_Terulet;
        private System.Windows.Forms.TextBox textBox_Fovaros;
        private System.Windows.Forms.TextBox textBox_OrszagNeve;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

