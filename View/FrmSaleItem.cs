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
    public partial class FrmSaleItem : Form {
        public FrmSaleItem() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string search = textBox1.Text.ToLower();

            List<Product> products = Product.GetAllProducts();

            List<Product> filtered = products.Where(item => item.Description.ToLower().Contains(search)).ToList();

            DataTable dt = ConvertToDataTable(filtered);

            dataGridView1.DataSource = dt;

            //BindingSource bindingSource;

            //bindingSource = new BindingSource();

            //bindingSource.DataSource = filtered;

            //comboBox1.DataSource = bindingSource;

            //List<string> items = filtered.Select(item => item.Description).ToList();

            //comboBox1.DataSource = items;
        }

        public static DataTable ConvertToDataTable(List<Product> products) {
            DataTable dt = new DataTable();

            // Define as colunas
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Brand", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Stock", typeof(int));

            // Preenche o DataTable com os dados da lista
            foreach (var product in products) {
                DataRow row = dt.NewRow();
                row["Id"] = product.Id;
                row["Description"] = product.Description;
                row["Brand"] = product.Brand;
                row["Price"] = product.Price;
                row["Stock"] = product.Stock;
                dt.Rows.Add(row);
            }

            return dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            string description = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string price = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            labelDescription.Text = description;
            labelPrice.Text = price;

            textQuantity.Focus();
        }

        private void button2_Click(object sender, EventArgs e) {
            decimal price = decimal.Parse(labelPrice.Text);

            int quantity = int.Parse(textQuantity.Text);

            DialogResult result = MessageBox.Show("Confirmar venda?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                if (quantity > 0) {
                    decimal amout = quantity * price;
                    MessageBox.Show(amout.ToString());
                }
            }
        }
    }
}
