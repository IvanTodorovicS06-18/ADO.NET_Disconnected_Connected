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
    public partial class InsertForma : Form
    {
        public InsertForma()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text.Trim() == "" || txtKontakt.Text.Trim() == "" || txtGrad.Text.Trim() == "" || txtZemlja.Text.Trim() == "")
            {
                MessageBox.Show("Popunite sva polja!");
            }
            else
            {
                clsDataAccsess vr = new clsDataAccsess();

                int Ret = vr.insertKlijenta(txtNaziv.Text, txtKontakt.Text, txtGrad.Text, txtZemlja.Text);

                MessageBox.Show(Ret.ToString());

                if (Ret == 0)
                {
                    MessageBox.Show("Uspesno ste dodali korisnika");

                }
            }
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertForma_Load(object sender, EventArgs e)
        {

        }
    }
}
