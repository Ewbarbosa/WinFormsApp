using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Model {
    public class SaleItem {
        public int Id { get; set; }
        public int Sale_Id { get; set; }
        public int Product_Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public SaleItem(int id, int sale_Id, int product_Id, int quantity, decimal price) {
            Id = id;
            Sale_Id = sale_Id;
            Product_Id = product_Id;
            Quantity = quantity;
            Price = price;
        }

        public SaleItem() { }

        public static void Insert(int sale_id, int product_id, int quantity, decimal price) {
            dbConfig db = new dbConfig();
            string query = "insert into saleitem (sale_id, product_id, quantity, price) values (@sale_id, @product_id, @quantity, @price)";

            var paramters = new (string, object)[] { ("@sale_id", sale_id), ("@product_id", product_id), ("@quantity", quantity), ("@price", price) };

            db.ExecuteQueryWithParameters(query, paramters);
        }

        public static List<SaleItem> GetSaleItems(int sale_id) {
            List<SaleItem> list = new List<SaleItem>();
            dbConfig db = new dbConfig();

            string query = "select * from saleitem where sale_id = @sale_id";

            var paramters = new (string, object)[] { ("@sale_id", sale_id) };

            DataTable data = db.ExecuteQueryWithParameters(query, paramters);

            foreach (DataRow row in data.Rows) {
                int id = Convert.ToInt32(row["id"]);
                int saleId = Convert.ToInt32(row["sale_id"]);
                int product_id = Convert.ToInt32(row["product_id"]);
                int quantity = Convert.ToInt32(row["quantity"]);
                decimal price = Convert.ToDecimal(row["price"]);

                SaleItem sale = new SaleItem(id, saleId, product_id, quantity, price);
                list.Add(sale);
            }
            
            return list;
        }
    }
}
