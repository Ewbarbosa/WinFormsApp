using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Model {
    public class Sale {
        public int Id { get; set; }
        public int Client_id { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }

        public Sale(int id, int client_id, int quantity, decimal price) {
            Id = id;
            Client_id = client_id;
            this.quantity = quantity;
            this.price = price;
        }

        public Sale() { }

        public void Insert(int client_id, decimal amout) {
            dbConfig db = new dbConfig();
            string query = "insert into sale (client_id, amount) values (@client_id, @amount)";

            var paramters = new (string, object)[] { ("@description", client_id), ("@brand", amout) };

            db.ExecuteQueryWithParameters(query, paramters);
        }
    }
}
