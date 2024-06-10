using Npgsql;
using System.Data;
using System.Windows.Forms;
using WinFormsApp.Model;
using WinFormsApp.View;

namespace WinFormsApp {
    public partial class Main : Form {

        public Main() {
            InitializeComponent();
        }

        public void newForm() {
            Application.Run(new FrmDashboard());
        }

        private void button1_Click(object sender, EventArgs e) {

            // validação simples sem criar uma senha criptografada

            string username = textUser.Text;
            string password = textPass.Text;


            User user = User.GetUser(username, password);
            if (user == null) {
                MessageBox.Show("Usuário/Senha inválido!"); ;
            } else {
                FrmDashboard dashboard = new FrmDashboard();
                dashboard.FormClosed += (s, args) => this.Close();
                this.Hide();
                dashboard.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {            
            FrmNovoUsuario novoUsuario = new FrmNovoUsuario();
            novoUsuario.ShowDialog();
        }        
    }
}





