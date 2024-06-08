using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Model;

namespace WinFormsApp.View {
    public partial class FrmClient : Form {
        public FrmClient() {
            InitializeComponent();
        }

        private void FrmClient_Load(object sender, EventArgs e) {
            dataGridViewClient.DataSource = Client.Load();
        }

        private void button1_Click(object sender, EventArgs e) {
            FrmCRUDClient cliente = new FrmCRUDClient(0);
            cliente.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            string id = dataGridViewClient.Rows[e.RowIndex].Cells[0].Value.ToString();            

            FrmCRUDClient frm = new FrmCRUDClient(int.Parse(id));
            frm.ShowDialog();            
        }

        private void FrmClient_Shown(object sender, EventArgs e) {
            dataGridViewClient.DataSource = Client.Load();
        }
    }
}

