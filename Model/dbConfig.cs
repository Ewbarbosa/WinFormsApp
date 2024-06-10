using Npgsql;
using System.Data;

namespace WinFormsApp.Model {
    public class dbConfig {

        // configuração do banco de dados
        string connection = "Host=127.0.0.1;Port=5432;Username=postgres;Password=43908701;Database=dbSystem";

        // executa uma query sem parametros
        public DataTable ExecuteQuery(string query, params NpgsqlParameter[] parameters) {

            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(connection)) {
                try {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(query, conn)) {

                        cmd.Parameters.AddRange(parameters);

                        using (var adapter = new NpgsqlDataAdapter(cmd)) {
                            adapter.Fill(dt);
                        }
                    }
                } catch (Exception ex) {
                    throw new Exception($"Erro: {ex.Message}");
                }
            }

            return dt;
        }

        // executa uma query com parametros
        public DataTable ExecuteQueryWithParameters(string query, params (string, object)[] parameters) {

            DataTable dt = new DataTable();

            using (var conn = new NpgsqlConnection(connection)) {
                try {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(query, conn)) {
                        foreach (var (name, value) in parameters) {
                            cmd.Parameters.AddWithValue(name, value);
                        }

                        using (var adapter = new NpgsqlDataAdapter(cmd)) {
                            adapter.Fill(dt);
                        }
                    }
                } catch (Exception ex) {
                    throw new Exception($"Erro ao executar comando: {ex.Message}");
                }
            }

            return dt;
        }
    }
}