using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonectedKlasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsDataAccsess cc = new clsDataAccsess();
            cc.selectKlijenti(dg1Kupci);
        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            clsDataAccsess cc = new clsDataAccsess();
            cc.selectKlijenti(dg1Kupci);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoadInsertForm_Click(object sender, EventArgs e)
        {
            var InsertForma = new InsertForma();
            InsertForma.Show();
        }

        private void btnLoadUpdateForm_Click(object sender, EventArgs e)
        {
            int sel = (int)dg1Kupci.SelectedRows[0].Cells[0].Value;
            var UpdateForma = new UpdateForma(sel);
            UpdateForma.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsDataAccsess cc = new clsDataAccsess();
            int sel = (int)dg1Kupci.SelectedRows[0].Cells[0].Value;
            if (MessageBox.Show("Da li ste sigurni", "Brisanje reda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int ret = cc.Klient_Delete(sel);
                MessageBox.Show(ret.ToString());
            }
            else
            {
                MessageBox.Show("Red nije izbrisan", "Brisanje reda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
