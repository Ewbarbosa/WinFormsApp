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
            //LoadData(textUser.Text, textPass.Text);

            //List<User> users = User.GetAllUsers();
            //User.DeleteUser(1);
            //MessageBox.Show(users[0].Username);

            //if (textUser.Text == "admin" || textPass.Text == "admin") {
            //    this.Close();
            //    Dashboard dashboard = new Dashboard();
            //    dashboard.Show();
            //} else {
            //    MessageBox.Show("Usuário e senha incorretos!");
            //}

            User user = User.GetUser(textUser.Text, textPass.Text);
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





