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
    public partial class FrmProduct : Form {
        public FrmProduct() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            FrmCRUDProduct produto = new FrmCRUDProduct(0);
            produto.ShowDialog();
        }

        private void FrmProduct_Load(object sender, EventArgs e) {
            dataGridViewProduct.DataSource = Product.Load();
        }

        private void dataGridViewProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

            string _id = dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString();

            int id = int.Parse(_id);
                        
            FrmCRUDProduct produto = new FrmCRUDProduct(id);
            produto.ShowDialog();
        }
    }
}

