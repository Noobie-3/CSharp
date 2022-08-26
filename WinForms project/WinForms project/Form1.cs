using MySql.Data.MySqlClient;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

namespace WinForms_project {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        static string ConnectionString = "server = localhost; database = library; uid = root; pwd =; ";

        DataTable table = new DataTable();

        BindingSource bSource = new BindingSource();

        MySqlDataAdapter MyDA = new MySqlDataAdapter();

        MySqlConnection cnn = new MySqlConnection(ConnectionString);


        private void button1_Click_1(object sender, EventArgs e) {
            cnn.Open();
            string sqlSelectALL = "SELECT a.author_id, a.first_name, a.last_name, a.isbn, b.title, b.genre FROM author a INNER JOIN book b ON a.isbn = b.isbn";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectALL, cnn);
            MyDA.Fill(table);

            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            cnn.Close();
        }
        private void InsertBookButton_Click(object sender, EventArgs e) {

        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {

        }


    }
}

