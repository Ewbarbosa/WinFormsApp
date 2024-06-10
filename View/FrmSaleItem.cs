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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp.View {
    public partial class FrmSaleItem : Form {
        public FrmSaleItem() {
            InitializeComponent();
        }

        // Lista para armazenar abas escondidas
        private List<TabPage> hiddenTabPages = new List<TabPage>();
        private Client client;
        private Sale sale;
        private List<SaleItem> saleItems = new List<SaleItem>();

        private void button1_Click(object sender, EventArgs e) {
            string search = textBox1.Text.ToLower();

            List<Product> products = Product.GetAllProducts();

            List<Product> filtered = products.Where(item => item.Description.ToLower().Contains(search)).ToList();

            DataTable dt = ConvertToDataTable(filtered);

            dataGridViewProduct.DataSource = dt;
        }

        // converto uma Lista em DataTable
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

        // escondo uma aba
        private void HidePage(TabPage tabPage) {
            if (tabControl.TabPages.Contains(tabPage)) {
                hiddenTabPages.Add(tabPage);
                tabControl.TabPages.Remove(tabPage);
            }
        }

        // exibo uma aba
        private void ShowPage(TabPage tabPage) {
            if (hiddenTabPages.Contains(tabPage)) {
                tabControl.TabPages.Add(tabPage);
                hiddenTabPages.Remove(tabPage);
            }
        }

        private void FrmSaleItem_Load(object sender, EventArgs e) {
            HidePage(tabProduct);
            HidePage(tabPayment);
        }

        private void button4_Click(object sender, EventArgs e) {
            if (labelID.Text != "") {

                int id = int.Parse(labelID.Text);
                string name = labelName.Text;
                string address = labelAddress.Text;
                string phone = labelPhone.Text;
                string email = labelEmail.Text;

                client = new Client(id, name, address, phone, email);

                sale = Sale.Insert(id, 0, "Pendente");

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

                if (frm.InputValue != "") {

                    int quantity = int.Parse(frm.InputValue);

                    if (quantity > 0) {

                        int saleId = sale.Id;
                        int productId = int.Parse(dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
                        decimal price = decimal.Parse(dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString());

                        try {
                            // salva no banco
                            SaleItem.Insert(saleId, productId, quantity, price);

                            // cria um novo objeto SaleItem 
                            SaleItem item = new SaleItem(saleId, productId, quantity, price);

                            // adiciona a lista de SaleItem um novo objeto
                            saleItems.Add(item);

                            // atualiza o valor do objeto sale
                            sale.Amount = sale.Amount + (quantity * price);

                            decimal totalValue = 0;
                            int nItems = 0;

                            foreach (SaleItem items in saleItems) {
                                totalValue += (items.Quantity * items.Price);
                                nItems += items.Quantity;
                            }

                            sale.Amount = totalValue;

                            MessageBox.Show("Item adicionado!");
                            label21.Text = nItems.ToString();
                            label23.Text = sale.Amount.ToString();

                            DataTable dt = ConvertToDataTable(saleItems);
                            dataGridViewSale.DataSource = dt;
                        } catch (Exception ex) {
                            MessageBox.Show("Erro: " + ex.Message);
                        }
                    }
                }

            } else {
                MessageBox.Show("Operação cancelada.");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (saleItems.Count > 0) {
                HidePage(tabProduct);
                ShowPage(tabPayment);

                int nItems = 0;

                foreach (SaleItem item in saleItems) {
                    nItems += item.Quantity;
                }

                label17.Text = sale.Id.ToString();
                label14.Text = client.Name;
                label16.Text = client.Address;
                label20.Text = nItems.ToString();
                label12.Text = sale.Amount.ToString();
            } else {
                MessageBox.Show("Adicione ao menos um item para continuar.");
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex > 0) {
                try {
                    Sale.UpdateCheckout(sale.Id, sale.Amount, sale.Payment);

                    int nItems = 0;

                    // para cada item em saleItems
                    foreach (var item in saleItems) {
                        // atualiza o estoque
                        Product.UpdateStock(item.Product_Id, item.Quantity);

                        nItems += item.Quantity;
                    }

                    string resume =
                    "Venda #" + sale.Id.ToString() + " - " + sale.Created_At.ToString() + "\n" +
                    "Cliente: " + client.Name + "\n" +
                    "Total de Itens: " + nItems.ToString() + "\n" +
                    "Forma de Pagamento: " + sale.Payment + "\n" +
                    "Total da Compra: " + sale.Amount.ToString() + "\n";

                    MessageBox.Show(resume);
                    this.Close();

                } catch (Exception ex) {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            } else {
                MessageBox.Show("Selecione a forma de pagamento.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {            
            string selectedItem = comboBox1.Text;

            sale.Payment = selectedItem;
        }
    }
}