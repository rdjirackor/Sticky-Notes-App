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
        internal virtual void SetPlaceholderText(Control textBox, string hint)
        {
            if (textBox is TextBoxBase textControl) // TextBoxBase is the base class for both TextBox and RichTextBox
            {
                // Set the initial placeholder text
                textControl.Text = hint;
                textControl.ForeColor = Color.Gray;

                // Handle the Focus event to clear the hint when the user focuses on the control
                textControl.Enter += (sender, e) =>
                {
                    if (textControl.Text == hint)
                    {
                        textControl.Text = "";
                        textControl.ForeColor = Color.Black;
                    }
                };

                // Handle the Leave event to restore the hint if the control is empty
                textControl.Leave += (sender, e) =>
                {
                    if (string.IsNullOrWhiteSpace(textControl.Text))
                    {
                        textControl.Text = hint;
                        textControl.ForeColor = Color.Gray;
                    }
                };
            }
        }
        internal virtual void SetPlaceholderText(TextBox textBox, string hint)
        {
            SetPlaceholderTextCommon(textBox, hint);
        }

        internal virtual void SetPlaceholderText(RichTextBox richTextBox, string hint)
        {
            SetPlaceholderTextCommon(richTextBox, hint);
        }

        private void SetPlaceholderTextCommon(TextBoxBase textControl, string hint)
        {
            // Set the initial placeholder text
            textControl.Text = hint;
            textControl.ForeColor = Color.Gray;

            // Handle the Focus event to clear the hint when the user focuses on the control
            textControl.Enter += (sender, e) =>
            {
                if (textControl.Text == hint)
                {
                    textControl.Text = "";
                    textControl.ForeColor = Color.Black;
                }
            };

            textControl.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textControl.Text))
                {
                    textControl.Text = hint;
                    textControl.ForeColor = Color.Gray;
                }
            };
        }


        public string EnteredText
        {
            get { return textBox1.Text;}
        }
        public string EnteredText2
        {
            get { return richTextBox.Text;}
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditPage_Load(object sender, EventArgs e)
        {
            textBox1.Height = 1300;
                this.WindowState = FormWindowState.Maximized;
            SetPlaceholderText(textBox1, "Enter your title here...");
            
            SetPlaceholderText(richTextBox, "Enter your note here...");
            CenterControl(textBox1);
            CenterControl(richTextBox);




        }

        private void Button_Done(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string text2 = richTextBox.Text;

            // Save the text to the database
            SaveTextToDatabase(text,text2);

            FirstPage newForm = new FirstPage();
            newForm.Show();
            this.Hide();
        }
        private void FormClosed_(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        private void SaveTextToDatabase(string text, string text2)
        {

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Notes (Id INTEGER PRIMARY KEY AUTOINCREMENT, Text TEXT, Note TEXT)", connection))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO Notes (Text), (Note) VALUES (@text) (@text2)";
                    command.Parameters.AddWithValue("@text", text);
                    command.Parameters.AddWithValue("@text2", text2);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void CenterControl(Control control)
        {
            int x = (control.Parent.ClientSize.Width - control.Width) / 2;

            control.Location = new Point(x, control.Location.Y);
        }

    }
}
