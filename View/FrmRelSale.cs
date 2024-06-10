using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Model;

namespace WinFormsApp.View {
    public partial class FrmRelSale : Form {
        public FrmRelSale() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {            

            string strDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            List<Sale> list = Sale.GetSale();

            List<Sale> filtered = list.Where(item => item.Created_At.Date == DateTime.Parse(strDate)).ToList();

            DataTable dt = ConvertToDataTable(filtered);

            dataGridView1.DataSource = dt;
        }

        // converto uma Lista em DataTable
        public static DataTable ConvertToDataTable<T>(List<T> items) {
            DataTable dataTable = new DataTable(typeof(T).Name);

            // Obter todas as propriedades da classe T
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Definir as colunas do DataTable
            foreach (PropertyInfo prop in Props) {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            // Adicionar linhas ao DataTable
            foreach (T item in items) {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++) {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}
