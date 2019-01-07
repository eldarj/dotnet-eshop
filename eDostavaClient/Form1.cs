using eDostavaClient.eDostavaServis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDostavaClient
{
    public partial class RestoranOverview : Form
    {
        private eDostavaServisSoapClient klijent = new eDostavaServisSoapClient();

        public RestoranOverview()
        {
            InitializeComponent();
            dgvRestorani.AutoGenerateColumns = false;
            dgvRestorani.AutoSize = true;

            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = "Id";
            col.Name = "#";
            dgvRestorani.Columns.Add(col);

            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "Naziv";
            col2.Name = "Naziv";
            dgvRestorani.Columns.Add(col2);

            DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "Ime";
            col3.Name = "Vlasnik ime";
            dgvRestorani.Columns.Add(col3);

            DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "Prezime";
            col4.Name = "Vlasnik prezime";
            dgvRestorani.Columns.Add(col4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBlokovi.DataSource = klijent.GetBlokovi();
            cmbBlokovi.ValueMember = "Id";
            cmbBlokovi.DisplayMember = "Naziv";
        }

        private void btnPretraziRestorane_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = klijent.GetRestoraniByBlok(int.Parse(cmbBlokovi.SelectedValue.ToString()));
            dgvRestorani.DataSource = source;
        }

    }
}
