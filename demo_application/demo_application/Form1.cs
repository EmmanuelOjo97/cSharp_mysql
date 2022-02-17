using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace demo_application
{
    public partial class Form1 : Form
    {
        // string connetionString;
        //MySqlConnection cnn;
        //string connetionString = @"Data Source=localhost; Initial Catalog=mydb ;User ID=root;Password=root";
        // cnn = new MySqlConnection(connetionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string connetionString;
            MySqlConnection cnn;
            connetionString = @"Data Source=localhost; Initial Catalog=mydb ;User ID=root;Password=root";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataReader dataReader;
            string sql, Output = "";
            sql = "SELECT * FROM movie";
            command = new MySqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetString(1) + "\n";
            }

            MessageBox.Show(Output);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userTitle, userRating;
            string movie_title, rating;
            string connectionString;
            rating = "PG-13";
            movie_title = "Avengers";
            int length, release_date;
            double movie_price;
            length = 100;
            release_date = 2019;
            movie_price = 10.99;
            MySqlConnection cnn;
            connectionString = @"Data Source=localhost; Initial Catalog=mydb ;User ID=root;Password=root";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand dataReader;
            string sql = "";
            sql = $"insert into mydb.movie (title,length,release_date,rating,movie_price) VALUES (\"" + movie_title + "\", " + length + ", " + release_date + ",\"" + rating + "\"," + movie_price + " )";
            command = new MySqlCommand(sql, cnn);
            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string movie_title, rating;
            string connectionString;
            rating = "PG-13";
            movie_title = "Avengers";
            int length, release_date;
            double movie_price;
            length = 100;
            release_date = 2019;
            movie_price = 10.99;
            MySqlConnection cnn;
            connectionString = @"Data Source=localhost; Initial Catalog=mydb ;User ID=root;Password=root";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "";
            sql = $"DELETE FROM mydb.movie WHERE movie_id= " + 3 + " ";
            command = new MySqlCommand(sql, cnn);
            adapter.DeleteCommand = new MySqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string movie_title, rating;
            string connectionString;
            rating = "PG-13";
            movie_title = "Frozen";
            int length, release_date;
            double movie_price;
            length = 100;
            release_date = 2019;
            movie_price = 10.99;
            MySqlConnection cnn;
            connectionString = @"Data Source=localhost; Initial Catalog=mydb ;User ID=root;Password=root";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "";
            sql = "Update mydb.movie set title = \"Frozen\" where title = \"Avengers\"";
            command = new MySqlCommand(sql, cnn);
            adapter.UpdateCommand = new MySqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string userTitle, userRating;
            int inputLength, inputReleaseDate;
            double inputMoviePrice;
            userTitle = textBox1.Text;
            userRating = textBox2.Text;
            inputLength = Convert.ToInt32(textBox3.Text);
            inputReleaseDate = Convert.ToInt32(textBox4.Text);
            inputMoviePrice = Convert.ToDouble(textBox5.Text);
            string connectionString;
            MySqlConnection cnn;
            connectionString = @"Data Source=localhost; Initial Catalog=mydb ;User ID=root;Password=root";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            MySqlCommand command;
            MySqlCommand dataReader;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "";
            sql = $"insert into mydb.movie (title,length,release_date,rating,movie_price) VALUES (\"" + userTitle + "\", " + inputLength + ", " + inputReleaseDate + ",\"" + userRating + "\"," + inputMoviePrice + " )";
            command = new MySqlCommand(sql, cnn);
            adapter.InsertCommand = new MySqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int movie_id;

            string movie_title;
            string connectionString;
            //rating = "PG-13";
            movie_title = textBox1.Text;
            movie_id = Convert.ToInt32(textBox6.Text);
            MySqlConnection cnn;
            connectionString = @"Data Source=localhost; Initial Catalog=mydb ;User ID=root;Password=root";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string Output = "Movie with id of " + movie_id + " has been deleted";
            string sql = "";
            sql = $"DELETE FROM mydb.movie WHERE movie_id= " + movie_id + "";
            command = new MySqlCommand(sql, cnn);
            adapter.DeleteCommand = new MySqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
            MessageBox.Show(Output);
        }





        private void button7_Click(object sender, EventArgs e)
        {
            string movie_title, rating;
            string connectionString;
            rating = "PG-13";
            movie_title = textBox1.Text;
            int movie_id = Convert.ToInt32(textBox6.Text);
            int length, release_date;
            double movie_price;
            length = 100;
            release_date = 2019;
            movie_price = 10.99;
            MySqlConnection cnn;
            connectionString = @"Data Source=localhost; Initial Catalog=mydb ;User ID=root;Password=root";
            cnn = new MySqlConnection(connectionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "";
            sql = "Update mydb.movie set title = \"" + movie_title + "\" where movie_id = " + movie_id + "";
            // sql = "Update mydb.movie set title = \"" + movie_title + "\" where movie_id = " + 4 + "";
            command = new MySqlCommand(sql, cnn);
            adapter.UpdateCommand = new MySqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }


    }
}