using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Model {
    public class Product {
        private Product product;

        public int Id { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(int id, string description, string brand, decimal price, int stock) {
            Id = id;
            Description = description;
            Brand = brand;
            Price = price;
            Stock = stock;
        }

        public Product() { }

        public Product(Product product) {
            this.product = product;
        }

        public static List<Product> GetAllProducts() {
            List<Product> products = new List<Product>();
            dbConfig db = new dbConfig();

            string query = "SELECT * FROM products";

            DataTable dataTable = db.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows) {
                int id = Convert.ToInt32(row["id"]);
                string description = row["description"].ToString();
                string brand = row["brand"].ToString();
                decimal price = Convert.ToDecimal(row["price"]);
                int stock = Convert.ToInt32(row["stock"]);

                Product product = new Product(id, description, brand, price, stock);
                products.Add(product);
            }

            return products;
        }

        public static DataTable Load() {            
            dbConfig db = new dbConfig();

            string query = "SELECT * FROM products";

            DataTable dataTable = db.ExecuteQuery(query);

            return dataTable;
        }

        public static Product GetProductById(int id) {
            dbConfig db = new dbConfig();

            string query = "select * from products where id = @id";

            var paramters = new (string, object)[] { ("@id", id) };

            DataTable data = db.ExecuteQueryWithParameters(query, paramters);

            if (data != null) {
                DataRow row = data.Rows[0];

                Product product = new Product {
                    Id = Convert.ToInt32(row["id"]),
                    Description = row["description"].ToString(),
                    Brand = row["brand"].ToString(),
                    Price = Convert.ToDecimal(row["price"]),
                    Stock = Convert.ToInt32(row["stock"])
                };
                return product;
            }
            return null;
        }

        public static void Insert(string description, string brand, decimal price, int stock){
            dbConfig db = new dbConfig();
            string query = "insert into products (description, brand, price, stock) values (@description, @brand, @price, @stock)";

            var paramters = new (string, object)[] { ("@description", description), ("@brand", brand), ("@price", price), ("stock", stock) };

            db.ExecuteQueryWithParameters(query, paramters);
        }

        public static void Update(int id, string description, string brand, decimal price, int stock) {
            dbConfig db = new dbConfig();
            string query = "update products set description = @description, brand = @brand, price = @price, stock = @stock where id = @id";

            var paramters = new (string, object)[] { ("id", id), ("@description", description), ("@brand", brand), ("@price", price), ("stock", stock) };

            db.ExecuteQueryWithParameters(query, paramters);
        }

        public static void Delete(int id) {
            dbConfig db = new dbConfig();

            string query = "delete from products where id = @id";

            var paramters = new (string, object)[] { ("id", id) };

            db.ExecuteQueryWithParameters(query, paramters);
        }
    }
}
