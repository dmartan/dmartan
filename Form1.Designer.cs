namespace Farmeri
{
    partial class Farmer
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
            this.spolTextbox = new System.Windows.Forms.TextBox();
            this.bojaTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gumbDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gumbFiltarBoja = new System.Windows.Forms.Button();
            this.filtarBojeTextbox = new System.Windows.Forms.TextBox();
            this.filtarBojaIspis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ispisFiltarSpola = new System.Windows.Forms.TextBox();
            this.filtarSpolTextbox = new System.Windows.Forms.TextBox();
            this.gumbFiltarSpola = new System.Windows.Forms.Button();
            this.gumbSortiraj = new System.Windows.Forms.Button();
            this.ispisSortirano = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // spolTextbox
            // 
            this.spolTextbox.Location = new System.Drawing.Point(114, 73);
            this.spolTextbox.Name = "spolTextbox";
            this.spolTextbox.Size = new System.Drawing.Size(100, 20);
            this.spolTextbox.TabIndex = 0;
            // 
            // bojaTextbox
            // 
            this.bojaTextbox.Location = new System.Drawing.Point(114, 122);
            this.bojaTextbox.Name = "bojaTextbox";
            this.bojaTextbox.Size = new System.Drawing.Size(100, 20);
            this.bojaTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SPOL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BOJA";
            // 
            // gumbDodaj
            // 
            this.gumbDodaj.Location = new System.Drawing.Point(90, 173);
            this.gumbDodaj.Name = "gumbDodaj";
            this.gumbDodaj.Size = new System.Drawing.Size(75, 23);
            this.gumbDodaj.TabIndex = 2;
            this.gumbDodaj.Text = "DODAJ";
            this.gumbDodaj.UseVisualStyleBackColor = true;
            this.gumbDodaj.Click += new System.EventHandler(this.gumbDodaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "BOJA";
            // 
            // gumbFiltarBoja
            // 
            this.gumbFiltarBoja.Location = new System.Drawing.Point(454, 60);
            this.gumbFiltarBoja.Name = "gumbFiltarBoja";
            this.gumbFiltarBoja.Size = new System.Drawing.Size(75, 50);
            this.gumbFiltarBoja.TabIndex = 4;
            this.gumbFiltarBoja.Text = "FILTAR BOJA";
            this.gumbFiltarBoja.UseVisualStyleBackColor = true;
            this.gumbFiltarBoja.Click += new System.EventHandler(this.gumbFiltarBoja_Click);
            // 
            // filtarBojeTextbox
            // 
            this.filtarBojeTextbox.Location = new System.Drawing.Point(279, 76);
            this.filtarBojeTextbox.Name = "filtarBojeTextbox";
            this.filtarBojeTextbox.Size = new System.Drawing.Size(100, 20);
            this.filtarBojeTextbox.TabIndex = 5;
            // 
            // filtarBojaIspis
            // 
            this.filtarBojaIspis.Location = new System.Drawing.Point(279, 125);
            this.filtarBojaIspis.Multiline = true;
            this.filtarBojaIspis.Name = "filtarBojaIspis";
            this.filtarBojaIspis.Size = new System.Drawing.Size(250, 136);
            this.filtarBojaIspis.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SPOL";
            // 
            // ispisFiltarSpola
            // 
            this.ispisFiltarSpola.Location = new System.Drawing.Point(638, 125);
            this.ispisFiltarSpola.Multiline = true;
            this.ispisFiltarSpola.Name = "ispisFiltarSpola";
            this.ispisFiltarSpola.Size = new System.Drawing.Size(250, 136);
            this.ispisFiltarSpola.TabIndex = 3;
            // 
            // filtarSpolTextbox
            // 
            this.filtarSpolTextbox.Location = new System.Drawing.Point(638, 76);
            this.filtarSpolTextbox.Name = "filtarSpolTextbox";
            this.filtarSpolTextbox.Size = new System.Drawing.Size(100, 20);
            this.filtarSpolTextbox.TabIndex = 5;
            // 
            // gumbFiltarSpola
            // 
            this.gumbFiltarSpola.Location = new System.Drawing.Point(813, 60);
            this.gumbFiltarSpola.Name = "gumbFiltarSpola";
            this.gumbFiltarSpola.Size = new System.Drawing.Size(75, 45);
            this.gumbFiltarSpola.TabIndex = 6;
            this.gumbFiltarSpola.Text = "FILTAR SPOLA";
            this.gumbFiltarSpola.UseVisualStyleBackColor = true;
            this.gumbFiltarSpola.Click += new System.EventHandler(this.gumbFiltarSpola_Click);
            // 
            // gumbSortiraj
            // 
            this.gumbSortiraj.Location = new System.Drawing.Point(183, 316);
            this.gumbSortiraj.Name = "gumbSortiraj";
            this.gumbSortiraj.Size = new System.Drawing.Size(75, 23);
            this.gumbSortiraj.TabIndex = 7;
            this.gumbSortiraj.Text = "SORTIRAJ";
            this.gumbSortiraj.UseVisualStyleBackColor = true;
            this.gumbSortiraj.Click += new System.EventHandler(this.gumbSortiraj_Click);
            // 
            // ispisSortirano
            // 
            this.ispisSortirano.Location = new System.Drawing.Point(278, 316);
            this.ispisSortirano.Multiline = true;
            this.ispisSortirano.Name = "ispisSortirano";
            this.ispisSortirano.Size = new System.Drawing.Size(221, 128);
            this.ispisSortirano.TabIndex = 8;
            // 
            // Farmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 470);
            this.Controls.Add(this.ispisSortirano);
            this.Controls.Add(this.gumbSortiraj);
            this.Controls.Add(this.gumbFiltarSpola);
            this.Controls.Add(this.filtarSpolTextbox);
            this.Controls.Add(this.filtarBojeTextbox);
            this.Controls.Add(this.gumbFiltarBoja);
            this.Controls.Add(this.ispisFiltarSpola);
            this.Controls.Add(this.filtarBojaIspis);
            this.Controls.Add(this.gumbDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bojaTextbox);
            this.Controls.Add(this.spolTextbox);
            this.Name = "Farmer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox spolTextbox;
        private System.Windows.Forms.TextBox bojaTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gumbDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gumbFiltarBoja;
        private System.Windows.Forms.TextBox filtarBojeTextbox;
        private System.Windows.Forms.TextBox filtarBojaIspis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ispisFiltarSpola;
        private System.Windows.Forms.TextBox filtarSpolTextbox;
        private System.Windows.Forms.Button gumbFiltarSpola;
        private System.Windows.Forms.Button gumbSortiraj;
        private System.Windows.Forms.TextBox ispisSortirano;
    }
}

