using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace WinFormsApp.Model {
    public class Client {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Client(int id, string name, string phone, string address, string email) {
            Id = id;
            Name = name;
            Phone = phone;
            Address = address;
            Email = email;
        }

        public Client() { }

        public static DataTable Load() {
            dbConfig db = new dbConfig();

            string query = "SELECT * FROM clients";

            DataTable dataTable = db.ExecuteQuery(query);

            return dataTable;
        }

        public static List<Client> GetAllClients() {
            List<Client> clients = new List<Client>();
            dbConfig db = new dbConfig();

            string query = "SELECT * FROM clients";

            DataTable dataTable = db.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows) {
                int id = Convert.ToInt32(row["id"]);
                string name = row["name"].ToString();
                string phone = row["phone"].ToString();
                string address = row["address"].ToString();
                string email = row["email"].ToString();

                Client client = new Client(id, name, phone, address, email);
                clients.Add(client);
            }

            return clients;
        }

        public static Client GetClientById(int id) {
            dbConfig db = new dbConfig();

            string query = "select * from clients where id = @id";

            var paramters = new (string, object)[] { ("@id", id) };

            DataTable data = db.ExecuteQueryWithParameters(query, paramters);

            if (data != null) {
                DataRow row = data.Rows[0];

                Client client = new Client {
                    Id = Convert.ToInt32(row["id"]),
                    Name = row["name"].ToString(),
                    Phone = row["phone"].ToString(),
                    Address = row["address"].ToString(),
                    Email = row["email"].ToString()
                };
                return client;
            }
            return null;
        }

        public static void Insert(string name, string phone, string address, string email) {
            dbConfig db = new dbConfig();
            string query = "insert into clients (name, phone, address, email) values (@name, @phone, @address, @email)";

            var paramters = new (string, object)[] { ("@name", name), ("@phone", phone), ("@address", address), ("email", email) };

            db.ExecuteQueryWithParameters(query, paramters);
        }
        public static void Update(int id, string name, string phone, string address, string email) {
            dbConfig db = new dbConfig();
            string query = "update clients set name = @name, phone = @phone, address = @address, email = @email where id = @id";

            var paramters = new (string, object)[] { ("id", id), ("@name", name), ("@phone", phone), ("@address", address), ("email", email) };

            db.ExecuteQueryWithParameters(query, paramters);
        }

        public static void Delete(int id) {
            dbConfig db = new dbConfig();

            string query = "delete from clients where id = @id";

            var paramters = new (string, object)[] { ("id", id) };

            db.ExecuteQueryWithParameters(query, paramters);
        }
    }
}
