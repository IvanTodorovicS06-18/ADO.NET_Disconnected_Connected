
namespace KonectedKlasa
{
    partial class UpdateForma
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.lblZemlja = new System.Windows.Forms.Label();
            this.btnUpdateExc = new System.Windows.Forms.Button();
            this.txtCancelUpdate = new System.Windows.Forms.Button();
            this.txtKontaktUpdate = new System.Windows.Forms.TextBox();
            this.txtGradUpdate = new System.Windows.Forms.TextBox();
            this.txtZemljaUpdate = new System.Windows.Forms.TextBox();
            this.txtNazivUpdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(75, 69);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 14;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Location = new System.Drawing.Point(75, 125);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(44, 13);
            this.lblKontakt.TabIndex = 15;
            this.lblKontakt.Text = "Kontakt";
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Location = new System.Drawing.Point(75, 180);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(30, 13);
            this.lblGrad.TabIndex = 16;
            this.lblGrad.Text = "Grad";
            // 
            // lblZemlja
            // 
            this.lblZemlja.AutoSize = true;
            this.lblZemlja.Location = new System.Drawing.Point(75, 239);
            this.lblZemlja.Name = "lblZemlja";
            this.lblZemlja.Size = new System.Drawing.Size(38, 13);
            this.lblZemlja.TabIndex = 17;
            this.lblZemlja.Text = "Zemlja";
            // 
            // btnUpdateExc
            // 
            this.btnUpdateExc.Location = new System.Drawing.Point(153, 312);
            this.btnUpdateExc.Name = "btnUpdateExc";
            this.btnUpdateExc.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateExc.TabIndex = 18;
            this.btnUpdateExc.Text = "UPDATE";
            this.btnUpdateExc.UseVisualStyleBackColor = true;
            this.btnUpdateExc.Click += new System.EventHandler(this.btnUpdateExc_Click);
            // 
            // txtCancelUpdate
            // 
            this.txtCancelUpdate.Location = new System.Drawing.Point(406, 312);
            this.txtCancelUpdate.Name = "txtCancelUpdate";
            this.txtCancelUpdate.Size = new System.Drawing.Size(75, 23);
            this.txtCancelUpdate.TabIndex = 19;
            this.txtCancelUpdate.Text = "Cancel";
            this.txtCancelUpdate.UseVisualStyleBackColor = true;
            this.txtCancelUpdate.Click += new System.EventHandler(this.txtCancelUpdate_Click);
            // 
            // txtKontaktUpdate
            // 
            this.txtKontaktUpdate.Location = new System.Drawing.Point(141, 122);
            this.txtKontaktUpdate.Name = "txtKontaktUpdate";
            this.txtKontaktUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtKontaktUpdate.TabIndex = 20;
            // 
            // txtGradUpdate
            // 
            this.txtGradUpdate.Location = new System.Drawing.Point(141, 180);
            this.txtGradUpdate.Name = "txtGradUpdate";
            this.txtGradUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtGradUpdate.TabIndex = 21;
            // 
            // txtZemljaUpdate
            // 
            this.txtZemljaUpdate.Location = new System.Drawing.Point(141, 232);
            this.txtZemljaUpdate.Name = "txtZemljaUpdate";
            this.txtZemljaUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtZemljaUpdate.TabIndex = 22;
            // 
            // txtNazivUpdate
            // 
            this.txtNazivUpdate.Location = new System.Drawing.Point(141, 69);
            this.txtNazivUpdate.Name = "txtNazivUpdate";
            this.txtNazivUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtNazivUpdate.TabIndex = 23;
            // 
            // UpdateForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNazivUpdate);
            this.Controls.Add(this.txtZemljaUpdate);
            this.Controls.Add(this.txtGradUpdate);
            this.Controls.Add(this.txtKontaktUpdate);
            this.Controls.Add(this.txtCancelUpdate);
            this.Controls.Add(this.btnUpdateExc);
            this.Controls.Add(this.lblZemlja);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.lblKontakt);
            this.Controls.Add(this.lblNaziv);
            this.Name = "UpdateForma";
            this.Text = "UpdateForma";
            this.Load += new System.EventHandler(this.UpdateForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label lblZemlja;
        private System.Windows.Forms.Button btnUpdateExc;
        private System.Windows.Forms.Button txtCancelUpdate;
        private System.Windows.Forms.TextBox txtKontaktUpdate;
        private System.Windows.Forms.TextBox txtGradUpdate;
        private System.Windows.Forms.TextBox txtZemljaUpdate;
        private System.Windows.Forms.TextBox txtNazivUpdate;
    }
}