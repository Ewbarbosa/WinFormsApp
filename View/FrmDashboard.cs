using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.View {
    public partial class FrmDashboard : Form {
        public FrmDashboard() {
            InitializeComponent();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmClient frm = new FrmClient();
            frm.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmProduct frm = new FrmProduct();
            frm.ShowDialog();
        }

        private void testeToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmClient frm = new FrmClient();
            frm.ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmSaleItem frm = new FrmSaleItem();
            frm.ShowDialog();
        }
    }
}