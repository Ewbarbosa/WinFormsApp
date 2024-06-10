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
        public string Payment { get; set; }

        public Sale(int id, int client_id, decimal amount, DateTime created_at, string payment) {
            Id = id;
            Client_id = client_id;
            Amount = amount;
            Created_At = created_at;
            Payment = payment;
        }

        public Sale() { }

        // salva uma venda
        public static Sale Insert(int client_id, decimal amout, string payment) {
            dbConfig db = new dbConfig();
            string query = "insert into sale (client_id, amount, payment) values (@client_id, @amount, @payment)";

            var paramters = new (string, object)[] { ("@client_id", client_id), ("@amount", amout), ("@payment", payment) };

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
                    Created_At = Convert.ToDateTime(row["created_at"]),
                    Payment = row["payment"].ToString()
                };
                return sale;
            }

            return null;
        }

        // retorna uma lista de vendas
        public static List<Sale> GetSale() {
            List<Sale> sales = new List<Sale>();
            dbConfig db = new dbConfig();

            string query = "select * from sale";            

            DataTable data = db.ExecuteQuery(query);

            if (data != null) {                

                foreach (DataRow row in data.Rows) {
                    int id = Convert.ToInt32(row["id"]);
                    int client_id = Convert.ToInt32(row["client_id"]);
                    decimal amount = Convert.ToDecimal(row["amount"]);
                    DateTime date = DateTime.Parse(row["created_at"].ToString());
                    string payment = row["payment"].ToString();
                    Sale sale = new Sale(id, client_id, amount, date, payment);

                    sales.Add(sale);
                }              

                return sales;
            }
            return null;
        }

        // atualiza uma venda que está em pagamento
        public static void UpdateCheckout(int id, decimal amount, string payment) {

            dbConfig db = new dbConfig();
            string query = "update sale set amount = @amount, payment = @payment where id = @id";

            var paramters = new (string, object)[] { ("id", id), ("@amount", amount), ("@payment", payment) };

            db.ExecuteQueryWithParameters(query, paramters);
        }
    }
}
