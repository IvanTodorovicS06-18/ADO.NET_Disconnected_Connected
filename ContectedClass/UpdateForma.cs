using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace KonectedKlasa
{
    public partial class UpdateForma : Form
    {
        public UpdateForma(int sel)
        {
            InitializeComponent();
          
           this.vrednost = sel;
          
        }
        public int vrednost { set; get; }

        private void btnUpdateExc_Click(object sender, EventArgs e)
        {

            if (txtNazivUpdate.Text.Trim() == "" || txtKontaktUpdate.Text.Trim() == "" || txtGradUpdate.Text.Trim() == "" || txtZemljaUpdate.Text.Trim() == "")
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
            }
            else
            {
                clsDataAccsess cc = new clsDataAccsess();


                int Ret = cc.updateKlijent(vrednost, txtNazivUpdate.Text, txtKontaktUpdate.Text, txtGradUpdate.Text, txtZemljaUpdate.Text);

                MessageBox.Show(Ret.ToString());

                if (Ret == 0)
                {
                    MessageBox.Show("Uspesno", "Unos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
           
        }

        private void txtCancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateForma_Load(object sender, EventArgs e)
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["konekcija"].ConnectionString;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = connection;

            SqlCommand cm = new SqlCommand();

            cm.Connection = cn;

            cm.CommandType = CommandType.StoredProcedure;

            cm.CommandText = "Dbo.PrikazKlijentTxt";

         
            cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));

           cm.Parameters.AddWithValue("@klijentid", this.vrednost);

            cm.Parameters.Add(new SqlParameter("@naziv", SqlDbType.NVarChar, 40, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Current, ""));

            cm.Parameters.Add(new SqlParameter("@kontakt", SqlDbType.NVarChar, 30, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Current, ""));

            cm.Parameters.Add(new SqlParameter("@grad", SqlDbType.NVarChar, 15, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Current, ""));

            cm.Parameters.Add(new SqlParameter("@zemlja", SqlDbType.NVarChar, 15, ParameterDirection.Output, false, 0, 0, "", DataRowVersion.Current, ""));
            try
            {
                if (cn.State == ConnectionState.Closed) cn.Open();
                cm.ExecuteNonQuery();
                txtNazivUpdate.Text = cm.Parameters["@naziv"].Value.ToString();
                txtKontaktUpdate.Text = cm.Parameters["@kontakt"].Value.ToString();
                txtGradUpdate.Text = cm.Parameters["@grad"].Value.ToString();
                txtZemljaUpdate.Text = cm.Parameters["@zemlja"].Value.ToString();
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
