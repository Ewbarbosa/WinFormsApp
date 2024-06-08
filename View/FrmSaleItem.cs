using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Model;

namespace WinFormsApp.View {
    public partial class FrmSaleItem : Form {
        public FrmSaleItem() {
            InitializeComponent();
        }

        // Lista para armazenar abas escondidas
        private List<TabPage> hiddenTabPages = new List<TabPage>();

        private void button1_Click(object sender, EventArgs e) {
            string search = textBox1.Text.ToLower();

            List<Product> products = Product.GetAllProducts();

            List<Product> filtered = products.Where(item => item.Description.ToLower().Contains(search)).ToList();

            DataTable dt = ConvertToDataTable(filtered);

            dataGridViewProduct.DataSource = dt;
        }

        public static DataTable ConvertToDataTable<T>(List<T> items) {
            DataTable dataTable = new DataTable(typeof(T).Name);

            // Obter todas as propriedades da classe T
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Definir as colunas do DataTable
            foreach (PropertyInfo prop in Props) {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            // Adicionar linhas ao DataTable
            foreach (T item in items) {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++) {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        private void button3_Click(object sender, EventArgs e) {
            string search = textBox2.Text.ToLower();

            List<Client> clients = Client.GetAllClients();

            List<Client> filtered = clients.Where(item => item.Name.ToLower().Contains(search)).ToList();

            DataTable dt = ConvertToDataTable(filtered);

            dataGridViewClient.DataSource = dt;
        }

        private void HidePage(TabPage tabPage) {
            if (tabControl.TabPages.Contains(tabPage)) {
                hiddenTabPages.Add(tabPage);
                tabControl.TabPages.Remove(tabPage);
            }
        }

        private void ShowPage(TabPage tabPage) {
            if (hiddenTabPages.Contains(tabPage)) {
                tabControl.TabPages.Add(tabPage);
                hiddenTabPages.Remove(tabPage);
            }
        }

        private void FrmSaleItem_Load(object sender, EventArgs e) {
            HidePage(tabProduct);
        }

        private void button4_Click(object sender, EventArgs e) {
            if (labelID.Text != "") {
                // inicia uma venda relacionada ao cliente com o valor zerado
                Sale sale = Sale.Insert(int.Parse(labelID.Text), 0);

                labelSaleId.Text = sale.Id.ToString();

                HidePage(tabClient);
                ShowPage(tabProduct);
            } else {
                MessageBox.Show("Selecione o cliente para continuar");
            }
        }

        private void dataGridViewClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            string id = dataGridViewClient.Rows[e.RowIndex].Cells[0].Value.ToString();
            string name = dataGridViewClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            string address = dataGridViewClient.Rows[e.RowIndex].Cells[3].Value.ToString();
            string phone = dataGridViewClient.Rows[e.RowIndex].Cells[2].Value.ToString();
            string email = dataGridViewClient.Rows[e.RowIndex].Cells[4].Value.ToString();

            labelID.Text = id;
            labelName.Text = name;
            labelAddress.Text = address;
            labelPhone.Text = phone;
            labelEmail.Text = email;
        }

        private void button1_Click_1(object sender, EventArgs e) {
            string search = textBox1.Text.ToLower();

            List<Product> products = Product.GetAllProducts();

            List<Product> filtered = products.Where(item => item.Description.ToLower().Contains(search)).ToList();

            DataTable dt = ConvertToDataTable(filtered);

            dataGridViewProduct.DataSource = dt;
        }

        private void dataGridViewProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

            FrmInputBox frm = new FrmInputBox();

            if (frm.ShowDialog() == DialogResult.OK) {

                int input = int.Parse(frm.InputValue);

                if (input > 0) {
                    int saleId = int.Parse(labelSaleId.Text);
                    int productId = int.Parse(dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
                    decimal price = decimal.Parse(dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString());

                    try {
                        SaleItem.Insert(saleId, productId, input, price);
                        MessageBox.Show("Item adicionado!");
                        List<SaleItem> saleItems = SaleItem.GetSaleItems(saleId);
                        DataTable dt = ConvertToDataTable(saleItems);
                        dataGridViewSale.DataSource = dt;
                    } catch (Exception ex) {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }

            } else {
                MessageBox.Show("Operação cancelada.");
            }
        }
    }
}