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
            string myTitle = bookTitleText.Text;
            string myGenre = genreText.Text;
            int myIsbn = int.Parse(bookIsbnText.Text);
            cnn.Open();

            string sqlSelectAll = $"INSERT INTO book(isbn, title, genre) VALUES ({myIsbn}, \"{myTitle}\", \"{myGenre}\")";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, cnn);
            MyDA.Fill(table);

            bSource.DataSource = table;
            bookTitleText.Text = "";
            genreText.Text = "";
            cnn.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {

        }

        private void InsertAuthor_Click(object sender, EventArgs e) {
            int AuthorID = int.Parse(AuthorIDText.Text);
            string myFirstName = AuthorFnameText.Text;
            string myLastName = AuthorLnameText.Text;
            int myIsbn = int.Parse(bookIsbnText.Text);

            cnn.Open();

            string sqlSelectAll = $"INSERT INTO author(author_id, first_name, last_name, isbn) VALUES ({AuthorID}, \"{myFirstName}\", \"{myLastName}\", \"{myIsbn}\")";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, cnn);
            MyDA.Fill(table);

            bSource.DataSource = table;
            AuthorFnameText.Text = "";
            AuthorLnameText.Text = "";
            genreText.Text = "";
            AuthorIDText.Text = "";
            bookIsbnText.Text = "";

            cnn.Close();
        }


    }
}

