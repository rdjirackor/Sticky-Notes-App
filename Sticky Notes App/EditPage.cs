using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace Sticky_Notes_App
{
    public partial class EditPage : Form
    {
        private const string ConnectionString = "Data Source=notes.db;Version=3;";

        public EditPage()
        {
            InitializeComponent();
        }
        private void SetPlaceholderText(TextBox textBox, string hint)
        {
            // Set the initial placeholder text
            textBox.Text = hint;
            textBox.ForeColor = Color.Gray;

            // Handle the Focus event to clear the hint when user focuses on the TextBox
            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == hint)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            // Handle the Leave event to restore the hint if the TextBox is empty
            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = hint;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        public string EnteredText
        {
            get { return textBox1.Text; }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditPage_Load(object sender, EventArgs e)
        {
            textBox1.Height = 1300;
                this.WindowState = FormWindowState.Maximized;
            SetPlaceholderText(textBox1, "Enter your title here...");




        }
        private void Button_Done(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            // Save the text to the database
            SaveTextToDatabase(text);

            FirstPage newForm = new FirstPage();
            newForm.Show();
            this.Hide();
        }
        private void FormClosed_(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        private void SaveTextToDatabase(string text)
        {

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Notes (Id INTEGER PRIMARY KEY AUTOINCREMENT, Text TEXT)", connection))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO Notes (Text) VALUES (@text)";
                    command.Parameters.AddWithValue("@text", text);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
