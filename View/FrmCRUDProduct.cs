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
    public partial class FrmCRUDProduct : Form {

        private readonly int _id;

        public FrmCRUDProduct(int id) {
            InitializeComponent();
            _id = id;
            LoadData(id);
        }

        private void button1_Click(object sender, EventArgs e) {
            if (_id > 0) {
                UpdateProduct(_id);
            } else {
                InsertProduct();
            }
        }

        private void LoadData(int id) {
            if (id > 0) {

                Product product = Product.GetProductById(id);

                textDescription.Text = product.Description;
                textBrand.Text = product.Brand;
                textPrice.Text = product.Price.ToString();
                textStock.Text = product.Stock.ToString();

                labelTitle.Text = $"Atualização de Produto #{_id}";
                this.Text = "System - Atualização de Produto";
            }
        }
        public void InsertProduct() {
            string description = textDescription.Text;
            string brand = textBrand.Text;
            decimal price = decimal.Parse(textPrice.Text);
            int stock = int.Parse(textStock.Text);

            try {
                Product.Insert(description, brand, price, stock);
                MessageBox.Show("Salvo com Sucesso!");
                textDescription.Text = "";
                textBrand.Text = "";
                textPrice.Text = "";
                textStock.Text = "";

                DialogResult result = MessageBox.Show("Deseja cadastrar um novo Produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) {
                    this.Close();
                }

            } catch (Exception ex) {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void UpdateProduct(int id) {
            string description, brand;
            decimal price;
            int stock;

            description = textDescription.Text;
            brand = textBrand.Text;
            price = decimal.Parse(textPrice.Text);
            stock = int.Parse(textStock.Text);

            try {
                Product.Update(id, description, brand, price, stock);
                MessageBox.Show("Atualizado com sucesso!");
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteProduct() {
            try {
                Product.Delete(_id);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (_id > 0) {
                DialogResult result = MessageBox.Show("Deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    DeleteProduct();
                    MessageBox.Show("O produto foi apagado!");
                    this.Close();
                }
            }
        }

        private void textPrice_KeyPress(object sender, KeyPressEventArgs e) {
            // Verifica se o caractere pressionado não é um número, uma vírgula ou um caractere de controle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',') {
                // Cancela a entrada do caractere pressionado
                e.Handled = true;
            }

            // Permite apenas uma vírgula na entrada
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(',')) {
                // Cancela a entrada da vírgula se já houver uma na string
                e.Handled = true;
            }
        }

        private void textStock_KeyPress(object sender, KeyPressEventArgs e) {
            // Verifica se o caractere pressionado não é um número
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                // Cancela a entrada do caractere pressionado
                e.Handled = true;
            }
        }
    }
}