using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp.Model {
    public class Sale {
        public int Id { get; set; }
        public int Client_id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Created_At { get; set; }

    public Sale(int id, int client_id, decimal amount, DateTime created_at) {
            Id = id;
            Client_id = client_id;
            Amount = amount;
            Created_At = created_at;
        }

        public Sale() { }

        public static Sale Insert(int client_id, decimal amout) {
            dbConfig db = new dbConfig();
            string query = "insert into sale (client_id, amount) values (@client_id, @amount)";

            var paramters = new (string, object)[] { ("@client_id", client_id), ("@amount", amout) };

            db.ExecuteQueryWithParameters(query, paramters);

            query = "select * from sale where client_id = @client_id order by created_at desc limit 1";

            var paramters2 = new (string, object)[] { ("@client_id", client_id), ("@amount", amout) };

            DataTable data = db.ExecuteQueryWithParameters(query, paramters2);

            if (data != null) {

                DataRow row = data.Rows[0];

                Sale sale = new Sale {
                    Id = Convert.ToInt32(row["id"]),
                    Client_id = Convert.ToInt32(row["client_id"]),
                    Amount = Convert.ToInt32(row["amount"]),
                    Created_At = Convert.ToDateTime(row["created_at"])
                };
                return sale;
            }

            return null;
        }
    }
}
