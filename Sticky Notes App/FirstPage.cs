using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sticky_Notes_App
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void Label_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            if (label != null)
            {
                var result = MessageBox.Show("Do you want to delete this note?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int id = (int)label.Tag;
                    DeleteNoteFromDatabase(id);

                    label.Text = string.Empty;
                }
            }
        }

        private void DeleteNoteFromDatabase(int id)
        {
            using (var connection = new SQLiteConnection("Data Source=notes.db;Version=3;"))
            {
                connection.Open();
                using (var command = new SQLiteCommand("DELETE FROM Notes WHERE Id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }


      private void RetrieveDataFromDatabase()
{
    using (var connection = new SQLiteConnection("Data Source=notes.db;Version=3;"))
    {
        connection.Open();

        string query = "SELECT Id, Text, Note FROM Notes";

        using (var command = new SQLiteCommand(query, connection))
        {
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                int i = 1;
                while (reader.Read() && i <= 12)
                {
                    int id = reader.GetInt32(0);
                    string text = reader["Text"].ToString() + reader["Note"].ToString();
                    Control noteLabel = this.tablelayout.Controls.Find("note" + i, true).FirstOrDefault();
                    if (noteLabel != null && noteLabel is Label label)
                    {
                        label.Text = text;
                        label.Tag = id;
                       // label.Click += new EventHandler(Label_Click);
                    }
                    i++;
                }
            }
        }
    }
}



        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void First_Load(object sender, EventArgs e)
        {
            try
            { RetrieveDataFromDatabase(); }
            catch (System.Data.SQLite.SQLiteException) {
                MessageBox.Show("Click on the add button to write a note", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void Button_add(object sender, EventArgs e)
        {
            EditPage newForm = new EditPage();
            newForm.Show();
            this.Hide();
        }

        private void FormClosed_(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tablelayout_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
