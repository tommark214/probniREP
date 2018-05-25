namespace testnaAplikacija
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOznakaTima = new System.Windows.Forms.TextBox();
            this.txtNazivProjekta = new System.Windows.Forms.TextBox();
            this.cmbTimovi = new System.Windows.Forms.ComboBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lbPopisTimova = new System.Windows.Forms.ListBox();
            this.lbStudentiTima = new System.Windows.Forms.ListBox();
            this.btnSpremiTim = new System.Windows.Forms.Button();
            this.btnDodajStudenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // txtOznakaTima
            // 
            this.txtOznakaTima.Location = new System.Drawing.Point(119, 53);
            this.txtOznakaTima.Name = "txtOznakaTima";
            this.txtOznakaTima.Size = new System.Drawing.Size(100, 20);
            this.txtOznakaTima.TabIndex = 2;
            // 
            // txtNazivProjekta
            // 
            this.txtNazivProjekta.Location = new System.Drawing.Point(119, 89);
            this.txtNazivProjekta.Name = "txtNazivProjekta";
            this.txtNazivProjekta.Size = new System.Drawing.Size(100, 20);
            this.txtNazivProjekta.TabIndex = 3;
            // 
            // cmbTimovi
            // 
            this.cmbTimovi.FormattingEnabled = true;
            this.cmbTimovi.Location = new System.Drawing.Point(298, 53);
            this.cmbTimovi.Name = "cmbTimovi";
            this.cmbTimovi.Size = new System.Drawing.Size(121, 21);
            this.cmbTimovi.TabIndex = 4;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(506, 53);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 5;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(506, 102);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 6;
            // 
            // lbPopisTimova
            // 
            this.lbPopisTimova.FormattingEnabled = true;
            this.lbPopisTimova.Location = new System.Drawing.Point(78, 200);
            this.lbPopisTimova.Name = "lbPopisTimova";
            this.lbPopisTimova.Size = new System.Drawing.Size(157, 238);
            this.lbPopisTimova.TabIndex = 7;
            this.lbPopisTimova.SelectedIndexChanged += new System.EventHandler(this.lbPopisTimova_SelectedIndexChanged);
            // 
            // lbStudentiTima
            // 
            this.lbStudentiTima.FormattingEnabled = true;
            this.lbStudentiTima.Location = new System.Drawing.Point(336, 200);
            this.lbStudentiTima.Name = "lbStudentiTima";
            this.lbStudentiTima.Size = new System.Drawing.Size(150, 238);
            this.lbStudentiTima.TabIndex = 8;
            // 
            // btnSpremiTim
            // 
            this.btnSpremiTim.Location = new System.Drawing.Point(78, 131);
            this.btnSpremiTim.Name = "btnSpremiTim";
            this.btnSpremiTim.Size = new System.Drawing.Size(141, 53);
            this.btnSpremiTim.TabIndex = 9;
            this.btnSpremiTim.Text = "Spremi tim";
            this.btnSpremiTim.UseVisualStyleBackColor = true;
            this.btnSpremiTim.Click += new System.EventHandler(this.btnSpremiTim_Click);
            // 
            // btnDodajStudenta
            // 
            this.btnDodajStudenta.Location = new System.Drawing.Point(506, 146);
            this.btnDodajStudenta.Name = "btnDodajStudenta";
            this.btnDodajStudenta.Size = new System.Drawing.Size(150, 55);
            this.btnDodajStudenta.TabIndex = 10;
            this.btnDodajStudenta.Text = "Dodaj";
            this.btnDodajStudenta.UseVisualStyleBackColor = true;
            this.btnDodajStudenta.Click += new System.EventHandler(this.btnDodajStudenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajStudenta);
            this.Controls.Add(this.btnSpremiTim);
            this.Controls.Add(this.lbStudentiTima);
            this.Controls.Add(this.lbPopisTimova);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.cmbTimovi);
            this.Controls.Add(this.txtNazivProjekta);
            this.Controls.Add(this.txtOznakaTima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOznakaTima;
        private System.Windows.Forms.TextBox txtNazivProjekta;
        private System.Windows.Forms.ComboBox cmbTimovi;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ListBox lbPopisTimova;
        private System.Windows.Forms.ListBox lbStudentiTima;
        private System.Windows.Forms.Button btnSpremiTim;
        private System.Windows.Forms.Button btnDodajStudenta;
    }
}

