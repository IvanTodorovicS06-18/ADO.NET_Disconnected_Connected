
namespace KonectedKlasa
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
            this.dg1Kupci = new System.Windows.Forms.DataGridView();
            this.btnLoadInsertForm = new System.Windows.Forms.Button();
            this.btnLoadUpdateForm = new System.Windows.Forms.Button();
            this.btnRefreshGrid = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1Kupci)).BeginInit();
            this.SuspendLayout();
            // 
            // dg1Kupci
            // 
            this.dg1Kupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1Kupci.Location = new System.Drawing.Point(91, 69);
            this.dg1Kupci.Name = "dg1Kupci";
            this.dg1Kupci.Size = new System.Drawing.Size(661, 218);
            this.dg1Kupci.TabIndex = 0;
            // 
            // btnLoadInsertForm
            // 
            this.btnLoadInsertForm.Location = new System.Drawing.Point(91, 353);
            this.btnLoadInsertForm.Name = "btnLoadInsertForm";
            this.btnLoadInsertForm.Size = new System.Drawing.Size(89, 33);
            this.btnLoadInsertForm.TabIndex = 1;
            this.btnLoadInsertForm.Text = "INSERT";
            this.btnLoadInsertForm.UseVisualStyleBackColor = true;
            this.btnLoadInsertForm.Click += new System.EventHandler(this.btnLoadInsertForm_Click);
            // 
            // btnLoadUpdateForm
            // 
            this.btnLoadUpdateForm.Location = new System.Drawing.Point(231, 353);
            this.btnLoadUpdateForm.Name = "btnLoadUpdateForm";
            this.btnLoadUpdateForm.Size = new System.Drawing.Size(89, 33);
            this.btnLoadUpdateForm.TabIndex = 2;
            this.btnLoadUpdateForm.Text = "UPDATE";
            this.btnLoadUpdateForm.UseVisualStyleBackColor = true;
            this.btnLoadUpdateForm.Click += new System.EventHandler(this.btnLoadUpdateForm_Click);
            // 
            // btnRefreshGrid
            // 
            this.btnRefreshGrid.Location = new System.Drawing.Point(524, 353);
            this.btnRefreshGrid.Name = "btnRefreshGrid";
            this.btnRefreshGrid.Size = new System.Drawing.Size(89, 33);
            this.btnRefreshGrid.TabIndex = 4;
            this.btnRefreshGrid.Text = "Refresh grid";
            this.btnRefreshGrid.UseVisualStyleBackColor = true;
            this.btnRefreshGrid.Click += new System.EventHandler(this.btnRefreshGrid_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(663, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(367, 353);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 33);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefreshGrid);
            this.Controls.Add(this.btnLoadUpdateForm);
            this.Controls.Add(this.btnLoadInsertForm);
            this.Controls.Add(this.dg1Kupci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1Kupci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg1Kupci;
        private System.Windows.Forms.Button btnLoadInsertForm;
        private System.Windows.Forms.Button btnLoadUpdateForm;
        private System.Windows.Forms.Button btnRefreshGrid;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
    }
}

