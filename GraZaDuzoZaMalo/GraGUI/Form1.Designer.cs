namespace GraGUI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPoddaj = new System.Windows.Forms.Button();
            this.groupBoxOdgadywanie = new System.Windows.Forms.GroupBox();
            this.labelOcena = new System.Windows.Forms.Label();
            this.buttonWyślij = new System.Windows.Forms.Button();
            this.textBoxPropozycja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxStatystyki = new System.Windows.Forms.GroupBox();
            this.labelLiczbaRuchow = new System.Windows.Forms.Label();
            this.labelCzasGry = new System.Windows.Forms.Label();
            this.groupBoxLosowanie.SuspendLayout();
            this.groupBoxOdgadywanie.SuspendLayout();
            this.groupBoxStatystyki.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(12, 12);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosowanie
            // 
            this.groupBoxLosowanie.Controls.Add(this.buttonLosuj);
            this.groupBoxLosowanie.Controls.Add(this.textBoxDo);
            this.groupBoxLosowanie.Controls.Add(this.textBoxOd);
            this.groupBoxLosowanie.Controls.Add(this.label2);
            this.groupBoxLosowanie.Controls.Add(this.label1);
            this.groupBoxLosowanie.Location = new System.Drawing.Point(12, 41);
            this.groupBoxLosowanie.Name = "groupBoxLosowanie";
            this.groupBoxLosowanie.Size = new System.Drawing.Size(377, 103);
            this.groupBoxLosowanie.TabIndex = 1;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(197, 52);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonLosuj.TabIndex = 4;
            this.buttonLosuj.Text = "Losuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(68, 54);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDo.TabIndex = 3;
            this.textBoxDo.TextChanged += new System.EventHandler(this.textBoxDo_TextChanged);
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(68, 28);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 2;
            this.textBoxOd.TextChanged += new System.EventHandler(this.textBoxOd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Od";
            // 
            // buttonPoddaj
            // 
            this.buttonPoddaj.Location = new System.Drawing.Point(314, 12);
            this.buttonPoddaj.Name = "buttonPoddaj";
            this.buttonPoddaj.Size = new System.Drawing.Size(75, 23);
            this.buttonPoddaj.TabIndex = 2;
            this.buttonPoddaj.Text = "Poddaj";
            this.buttonPoddaj.UseVisualStyleBackColor = true;
            this.buttonPoddaj.Visible = false;
            this.buttonPoddaj.Click += new System.EventHandler(this.buttonPoddaj_Click);
            // 
            // groupBoxOdgadywanie
            // 
            this.groupBoxOdgadywanie.Controls.Add(this.labelOcena);
            this.groupBoxOdgadywanie.Controls.Add(this.buttonWyślij);
            this.groupBoxOdgadywanie.Controls.Add(this.textBoxPropozycja);
            this.groupBoxOdgadywanie.Controls.Add(this.label3);
            this.groupBoxOdgadywanie.Location = new System.Drawing.Point(12, 169);
            this.groupBoxOdgadywanie.Name = "groupBoxOdgadywanie";
            this.groupBoxOdgadywanie.Size = new System.Drawing.Size(377, 141);
            this.groupBoxOdgadywanie.TabIndex = 3;
            this.groupBoxOdgadywanie.TabStop = false;
            this.groupBoxOdgadywanie.Text = "Odgadnij";
            this.groupBoxOdgadywanie.Visible = false;
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(6, 94);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(39, 13);
            this.labelOcena.TabIndex = 3;
            this.labelOcena.Text = "Ocena";
            // 
            // buttonWyślij
            // 
            this.buttonWyślij.Location = new System.Drawing.Point(197, 58);
            this.buttonWyślij.Name = "buttonWyślij";
            this.buttonWyślij.Size = new System.Drawing.Size(75, 23);
            this.buttonWyślij.TabIndex = 2;
            this.buttonWyślij.Text = "Wyślij";
            this.buttonWyślij.UseVisualStyleBackColor = true;
            this.buttonWyślij.Click += new System.EventHandler(this.buttonWyślij_Click);
            // 
            // textBoxPropozycja
            // 
            this.textBoxPropozycja.Location = new System.Drawing.Point(68, 58);
            this.textBoxPropozycja.Name = "textBoxPropozycja";
            this.textBoxPropozycja.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropozycja.TabIndex = 1;
            this.textBoxPropozycja.TextChanged += new System.EventHandler(this.textBoxPropozycja_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Wylosowałem liczbę, odgadnij ją.";
            // 
            // groupBoxStatystyki
            // 
            this.groupBoxStatystyki.Controls.Add(this.labelCzasGry);
            this.groupBoxStatystyki.Controls.Add(this.labelLiczbaRuchow);
            this.groupBoxStatystyki.Location = new System.Drawing.Point(12, 329);
            this.groupBoxStatystyki.Name = "groupBoxStatystyki";
            this.groupBoxStatystyki.Size = new System.Drawing.Size(377, 105);
            this.groupBoxStatystyki.TabIndex = 4;
            this.groupBoxStatystyki.TabStop = false;
            this.groupBoxStatystyki.Text = "Statystyki";
            // 
            // labelLiczbaRuchow
            // 
            this.labelLiczbaRuchow.AutoSize = true;
            this.labelLiczbaRuchow.Location = new System.Drawing.Point(65, 32);
            this.labelLiczbaRuchow.Name = "labelLiczbaRuchow";
            this.labelLiczbaRuchow.Size = new System.Drawing.Size(0, 13);
            this.labelLiczbaRuchow.TabIndex = 0;
            // 
            // labelCzasGry
            // 
            this.labelCzasGry.AutoSize = true;
            this.labelCzasGry.Location = new System.Drawing.Point(68, 69);
            this.labelCzasGry.Name = "labelCzasGry";
            this.labelCzasGry.Size = new System.Drawing.Size(0, 13);
            this.labelCzasGry.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 469);
            this.Controls.Add(this.groupBoxStatystyki);
            this.Controls.Add(this.groupBoxOdgadywanie);
            this.Controls.Add(this.buttonPoddaj);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLosowanie.ResumeLayout(false);
            this.groupBoxLosowanie.PerformLayout();
            this.groupBoxOdgadywanie.ResumeLayout(false);
            this.groupBoxOdgadywanie.PerformLayout();
            this.groupBoxStatystyki.ResumeLayout(false);
            this.groupBoxStatystyki.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosowanie;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPoddaj;
        private System.Windows.Forms.GroupBox groupBoxOdgadywanie;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.Button buttonWyślij;
        private System.Windows.Forms.TextBox textBoxPropozycja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxStatystyki;
        private System.Windows.Forms.Label labelCzasGry;
        private System.Windows.Forms.Label labelLiczbaRuchow;
    }
}

