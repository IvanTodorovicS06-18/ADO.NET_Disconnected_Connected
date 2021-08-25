
namespace klk1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgKupci = new System.Windows.Forms.DataGridView();
            this.dgFaktura = new System.Windows.Forms.DataGridView();
            this.dgFakturaIStavke = new System.Windows.Forms.DataGridView();
            this.txtImeKupca = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKupacID = new System.Windows.Forms.ComboBox();
            this.lblKupacID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFakturaID = new System.Windows.Forms.ComboBox();
            this.txtNazivStavke = new System.Windows.Forms.TextBox();
            this.txtCenaStavke = new System.Windows.Forms.TextBox();
            this.btnUnesiKupca = new System.Windows.Forms.Button();
            this.btnFaktura = new System.Windows.Forms.Button();
            this.btnFakturaIStavke = new System.Windows.Forms.Button();
            this.lblFakturaID = new System.Windows.Forms.Label();
            this.lblNazivStavke = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.btnXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaktura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFakturaIStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKupci
            // 
            this.dgKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKupci.Location = new System.Drawing.Point(29, 276);
            this.dgKupci.Name = "dgKupci";
            this.dgKupci.RowTemplate.Height = 25;
            this.dgKupci.Size = new System.Drawing.Size(885, 75);
            this.dgKupci.TabIndex = 0;
            // 
            // dgFaktura
            // 
            this.dgFaktura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFaktura.Location = new System.Drawing.Point(29, 185);
            this.dgFaktura.Name = "dgFaktura";
            this.dgFaktura.RowTemplate.Height = 25;
            this.dgFaktura.Size = new System.Drawing.Size(885, 75);
            this.dgFaktura.TabIndex = 1;
            // 
            // dgFakturaIStavke
            // 
            this.dgFakturaIStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFakturaIStavke.Location = new System.Drawing.Point(29, 357);
            this.dgFakturaIStavke.Name = "dgFakturaIStavke";
            this.dgFakturaIStavke.RowTemplate.Height = 25;
            this.dgFakturaIStavke.Size = new System.Drawing.Size(885, 75);
            this.dgFakturaIStavke.TabIndex = 2;
            // 
            // txtImeKupca
            // 
            this.txtImeKupca.Location = new System.Drawing.Point(78, 38);
            this.txtImeKupca.Name = "txtImeKupca";
            this.txtImeKupca.Size = new System.Drawing.Size(96, 23);
            this.txtImeKupca.TabIndex = 3;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(78, 86);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(96, 23);
            this.txtAdresa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime kupca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adresa";
            // 
            // cmbKupacID
            // 
            this.cmbKupacID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKupacID.FormattingEnabled = true;
            this.cmbKupacID.Location = new System.Drawing.Point(311, 43);
            this.cmbKupacID.Name = "cmbKupacID";
            this.cmbKupacID.Size = new System.Drawing.Size(121, 23);
            this.cmbKupacID.TabIndex = 7;
            // 
            // lblKupacID
            // 
            this.lblKupacID.AutoSize = true;
            this.lblKupacID.Location = new System.Drawing.Point(237, 46);
            this.lblKupacID.Name = "lblKupacID";
            this.lblKupacID.Size = new System.Drawing.Size(54, 15);
            this.lblKupacID.TabIndex = 9;
            this.lblKupacID.Text = "Kupac ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datum";
            // 
            // cmbFakturaID
            // 
            this.cmbFakturaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFakturaID.FormattingEnabled = true;
            this.cmbFakturaID.Location = new System.Drawing.Point(584, 43);
            this.cmbFakturaID.Name = "cmbFakturaID";
            this.cmbFakturaID.Size = new System.Drawing.Size(168, 23);
            this.cmbFakturaID.TabIndex = 11;
            // 
            // txtNazivStavke
            // 
            this.txtNazivStavke.Location = new System.Drawing.Point(584, 84);
            this.txtNazivStavke.Name = "txtNazivStavke";
            this.txtNazivStavke.Size = new System.Drawing.Size(168, 23);
            this.txtNazivStavke.TabIndex = 12;
            // 
            // txtCenaStavke
            // 
            this.txtCenaStavke.Location = new System.Drawing.Point(584, 124);
            this.txtCenaStavke.Name = "txtCenaStavke";
            this.txtCenaStavke.Size = new System.Drawing.Size(166, 23);
            this.txtCenaStavke.TabIndex = 13;
            // 
            // btnUnesiKupca
            // 
            this.btnUnesiKupca.Location = new System.Drawing.Point(78, 131);
            this.btnUnesiKupca.Name = "btnUnesiKupca";
            this.btnUnesiKupca.Size = new System.Drawing.Size(96, 23);
            this.btnUnesiKupca.TabIndex = 14;
            this.btnUnesiKupca.Text = "Unesi Kupca";
            this.btnUnesiKupca.UseVisualStyleBackColor = true;
            this.btnUnesiKupca.Click += new System.EventHandler(this.btnUnesiKupca_Click);
            // 
            // btnFaktura
            // 
            this.btnFaktura.Location = new System.Drawing.Point(311, 124);
            this.btnFaktura.Name = "btnFaktura";
            this.btnFaktura.Size = new System.Drawing.Size(121, 30);
            this.btnFaktura.TabIndex = 15;
            this.btnFaktura.Text = "Unesi Fakturu";
            this.btnFaktura.UseVisualStyleBackColor = true;
            this.btnFaktura.Click += new System.EventHandler(this.btnFaktura_Click);
            // 
            // btnFakturaIStavke
            // 
            this.btnFakturaIStavke.Location = new System.Drawing.Point(584, 153);
            this.btnFakturaIStavke.Name = "btnFakturaIStavke";
            this.btnFakturaIStavke.Size = new System.Drawing.Size(168, 26);
            this.btnFakturaIStavke.TabIndex = 16;
            this.btnFakturaIStavke.Text = "Unesite fakturu i stavke";
            this.btnFakturaIStavke.UseVisualStyleBackColor = true;
            this.btnFakturaIStavke.Click += new System.EventHandler(this.btnFakturaIStavke_Click);
            // 
            // lblFakturaID
            // 
            this.lblFakturaID.AutoSize = true;
            this.lblFakturaID.Location = new System.Drawing.Point(508, 46);
            this.lblFakturaID.Name = "lblFakturaID";
            this.lblFakturaID.Size = new System.Drawing.Size(60, 15);
            this.lblFakturaID.TabIndex = 17;
            this.lblFakturaID.Text = "Faktura ID";
            // 
            // lblNazivStavke
            // 
            this.lblNazivStavke.AutoSize = true;
            this.lblNazivStavke.Location = new System.Drawing.Point(495, 90);
            this.lblNazivStavke.Name = "lblNazivStavke";
            this.lblNazivStavke.Size = new System.Drawing.Size(72, 15);
            this.lblNazivStavke.TabIndex = 18;
            this.lblNazivStavke.Text = "Naziv stavke";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cena stavke";
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(283, 84);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(200, 23);
            this.dtDatum.TabIndex = 20;
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(800, 45);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(138, 97);
            this.btnXML.TabIndex = 21;
            this.btnXML.Text = "Sacuvaj xml";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNazivStavke);
            this.Controls.Add(this.lblFakturaID);
            this.Controls.Add(this.btnFakturaIStavke);
            this.Controls.Add(this.btnFaktura);
            this.Controls.Add(this.btnUnesiKupca);
            this.Controls.Add(this.txtCenaStavke);
            this.Controls.Add(this.txtNazivStavke);
            this.Controls.Add(this.cmbFakturaID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKupacID);
            this.Controls.Add(this.cmbKupacID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtImeKupca);
            this.Controls.Add(this.dgFakturaIStavke);
            this.Controls.Add(this.dgFaktura);
            this.Controls.Add(this.dgKupci);
            this.Name = "Form1";
            this.Text = "Ivan Todorovic S06/18";
            ((System.ComponentModel.ISupportInitialize)(this.dgKupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaktura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFakturaIStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKupci;
        private System.Windows.Forms.DataGridView dgFaktura;
        private System.Windows.Forms.DataGridView dgFakturaIStavke;
        private System.Windows.Forms.TextBox txtImeKupca;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKupacID;
        private System.Windows.Forms.Label lblKupacID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFakturaID;
        private System.Windows.Forms.TextBox txtNazivStavke;
        private System.Windows.Forms.TextBox txtCenaStavke;
        private System.Windows.Forms.Button btnUnesiKupca;
        private System.Windows.Forms.Button btnFaktura;
        private System.Windows.Forms.Button btnFakturaIStavke;
        private System.Windows.Forms.Label lblFakturaID;
        private System.Windows.Forms.Label lblNazivStavke;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Button btnXML;
    }
}

