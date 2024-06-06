using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp.Model {
    public class User {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(int id, string username, string password) {
            Id = id;
            Username = username;
            Password = password;
        }

        public static List<User> GetAllUsers() {
            List<User> users = new List<User>();
            dbConfig db = new dbConfig();

            string query = "SELECT * FROM Users";

            DataTable dataTable = db.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows) {
                int id = Convert.ToInt32(row["id"]);
                string username = row["username"].ToString();
                string password = row["password"].ToString();

                User user = new User(id, username, password);
                users.Add(user);
            }

            return users;
        }

        public static User GetUser(string login, string pass) {

            dbConfig db = new dbConfig();

            string query = "select * from users where username = @username and password = @password";
            var parameters = new (string, object)[] { ("@username", login), ("@password", pass) };

            DataTable data = db.ExecuteQueryWithParameters(query, parameters);

            if (data.Rows.Count > 0) {
                DataRow row = data.Rows[0];

                User user = new User {
                    Id = Convert.ToInt32(row["id"]),
                    Username = row["username"].ToString(),
                    Password = row["password"].ToString()
                };
                return user;
            }
            return null;
        }

        public static void InsertUser(string username, string password) {
            dbConfig db = new dbConfig();
            string query = "INSERT INTO Users (username, password) VALUES (@username, @password)";
            var parameters = new (string, object)[] { ("@username", username), ("@password", password) };

            db.ExecuteQueryWithParameters(query, parameters);
        }

        public void UpdateUser() {
            dbConfig db = new dbConfig();
            string query = "UPDATE Users SET user = @username, password = @password WHERE id = @id";
            var parameters = new (string, object)[] { ("@username", Username), ("@password", Password), ("@id", Id) };

            db.ExecuteQueryWithParameters(query, parameters);
        }

        public static void DeleteUser(int id) {
            dbConfig db = new dbConfig();
            string query = "DELETE FROM Users WHERE id = @id";
            var parameters = new (string, object)[] { ("@id", id) };

            db.ExecuteQueryWithParameters(query, parameters);
        }

    }
}
