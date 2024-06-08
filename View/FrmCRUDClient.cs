using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp.View {
    public partial class FrmCRUDClient : Form {

        private readonly int _id;

        public FrmCRUDClient(int id) {
            InitializeComponent();
            _id = id;
            LoadData(id);
        }

        private void button1_Click(object sender, EventArgs e) {

            if (_id > 0) {
                UpdateClient(_id);
            } else {
                InsertClient();
            }
        }

        private void LoadData(int id) {
            if (id > 0) {
                Client client = Client.GetClientById(id);

                textName.Text = client.Name;
                textPhone.Text = client.Phone;
                textAddress.Text = client.Address;
                textEmail.Text = client.Email;

                labelTitle.Text = $"Atualização de Cliente #{_id}";
                this.Text = "System - Atualização de Cliente";
            }
        }

        private void UpdateClient(int id) {
            string name, phone, address, email;

            name = textName.Text;
            phone = textPhone.Text;
            address = textAddress.Text;
            email = textEmail.Text;

            try {
                Client.Update(id, name, phone, address, email);
                MessageBox.Show("Atualizado com sucesso!");
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertClient() {
            string name, phone, address, email;

            name = textName.Text;
            phone = textPhone.Text;
            address = textAddress.Text;
            email = textEmail.Text;

            try {
                Client.Insert(name, phone, address, email);
                MessageBox.Show("Salvo com sucesso");
                textName.Text = "";
                textPhone.Text = "";
                textAddress.Text = "";
                textEmail.Text = "";

                DialogResult result = MessageBox.Show("Deseja cadastrar um novo Cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) {
                    this.Close();
                }

            } catch (Exception ex) {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void DeleteClient() {
            try {
                Client.Delete(_id);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (_id > 0) {
                DialogResult result = MessageBox.Show("Deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    DeleteClient();
                    MessageBox.Show("O cliente foi apagado!");
                    this.Close();
                }
            }
        }
    }
}
