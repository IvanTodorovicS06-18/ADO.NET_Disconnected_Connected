using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klk1
{
    public partial class Form1 : Form
    {
        DataTable kupci = new DataTable("Kupci");
        DataTable fakture = new DataTable("Fakture");
        DataTable faktureStavke = new DataTable("FaktureStavke");
        DataSet kolekcija = new DataSet();

        public Form1()
        {
            InitializeComponent();

            //Tabela kupci

            DataColumn kupacID = new DataColumn("KupacID")
            {
                DataType = typeof(int),
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1

            };

            kupci.Columns.Add(kupacID);
            kupci.PrimaryKey = new DataColumn[] { kupacID };

            DataColumn NazivKupca = new DataColumn("NazivKupca")
            {
                DataType = typeof(string),
                MaxLength = 50,
                AllowDBNull = false
            };

            kupci.Columns.Add(NazivKupca);

            DataColumn Adresa = new DataColumn("Adresa")
            {
                DataType = typeof(string),
                MaxLength = 70,
                AllowDBNull = false
            };

            kupci.Columns.Add(Adresa);


            //Tabela faktura

            DataColumn fakturaID = new DataColumn("FakturaID")
            {
                DataType = typeof(int),
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1

            };

            fakture.Columns.Add(fakturaID);
            fakture.PrimaryKey = new DataColumn[] { fakturaID };

            DataColumn KkupacId = new DataColumn("KupacID")
            {
                DataType = typeof(int),
                AllowDBNull = false
            };

            fakture.Columns.Add(KkupacId);

            DataColumn datum = new DataColumn("Datum")
            {
                DataType = typeof(DateTime),
                DefaultValue = System.DateTime.Now

            };

            fakture.Columns.Add(datum);

          
            //Tabela faktura stavke
          

            DataColumn FfakturaID = new DataColumn("FakturaID")
            {
                DataType = typeof(int),
                AllowDBNull = false

            };

            faktureStavke.Columns.Add(FfakturaID);

            DataColumn NazivStavke = new DataColumn("NazivStavke")
            {
                DataType = typeof(string),
                MaxLength = 40,
                AllowDBNull = false

            };

            faktureStavke.Columns.Add(NazivStavke);

            DataColumn CenaStavke = new DataColumn("CenaStavke")
            {
                DataType = typeof(decimal),
                AllowDBNull = false,

            };

            faktureStavke.Columns.Add(CenaStavke);
            faktureStavke.PrimaryKey = new DataColumn[] { FfakturaID, NazivStavke };


            kolekcija.Tables.Add(kupci);
            kolekcija.Tables.Add(fakture);
            kolekcija.Tables.Add(faktureStavke);



            //Prikazivanje tabela u datagridu

            dgKupci.DataSource = kupci;
            dgFaktura.DataSource = fakture;
            dgFakturaIStavke.DataSource = faktureStavke;


            //Relacije


            DataRelation dataRelation = new DataRelation("RelacijaKupciFakture", kupci.Columns["KupacID"], fakture.Columns["KupacID"], true);
            kolekcija.Relations.Add(dataRelation);

            DataRelation dataRelation2 = new DataRelation("RelacijaFaktureStavkeFakture", fakture.Columns["FakturaID"], faktureStavke.Columns["FakturaID"], true);
            kolekcija.Relations.Add(dataRelation2);


            //constraints 

            try
            {
                ForeignKeyConstraint fk = (ForeignKeyConstraint)fakture.Constraints["RelacijaKupciFakture"];
                fk.DeleteRule = Rule.None;
                fk.UpdateRule = Rule.None;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };

            try
            {
                ForeignKeyConstraint fk2 = (ForeignKeyConstraint)faktureStavke.Constraints["RelacijaFaktureStavkeFakture"];
                fk2.DeleteRule = Rule.None;
                fk2.UpdateRule = Rule.None;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };


           //data binding

            cmbKupacID.DataSource = kupci;
            cmbKupacID.DisplayMember = "Kupac";
            cmbKupacID.ValueMember = "KupacID";


            cmbFakturaID.DataSource = fakture;
            cmbFakturaID.DisplayMember = "Faktura";
            cmbFakturaID.ValueMember = "FakturaID";

        }

        private void btnUnesiKupca_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtImeKupca.Text.Trim() == "" || txtAdresa.Text.Trim() == "")
                {
                    throw new Exception("Molim vas popunite sva polja");
                }

                kupci.Rows.Add(null, txtImeKupca.Text, txtAdresa.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void btnFaktura_Click(object sender, EventArgs e)
        {

            

            try
            {

                if (cmbKupacID.Text == "" )
                {
                    throw new Exception("Molim vas izaberite id kupca");
                }

                fakture.Rows.Add(null, cmbKupacID.SelectedValue, dtDatum.Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void btnFakturaIStavke_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFakturaID.Text == "")
                {
                    throw new Exception("Molim vas izaberite id fakture");
                }

                if (txtNazivStavke.Text.Trim() == "" || txtCenaStavke.Text.Trim() == "")
                {
                    throw new Exception("Molim vas popunite sva polja");
                }

                faktureStavke.Rows.Add( cmbFakturaID.SelectedValue, txtNazivStavke.Text, txtCenaStavke.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            kolekcija.AcceptChanges();
            kolekcija.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"//Stavke.xml", XmlWriteMode.WriteSchema);
            MessageBox.Show("Snimljeno");
        }
    }
}
