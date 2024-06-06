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
    public partial class FrmNovoUsuario : Form {
        public FrmNovoUsuario() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                User.InsertUser(textUsername.Text, textPassword.Text);
                MessageBox.Show("Usuário criado com sucesso!");
                textUsername.Text = "";
                textPassword.Text = "";
            } catch(Exception ex) {
                throw new Exception($"Erro: {ex.Message}");
            }            
        }
    }
}
