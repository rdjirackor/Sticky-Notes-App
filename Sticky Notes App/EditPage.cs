﻿using System;
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
        private void button_hover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        private void button_leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        private const string ConnectionString = "Data Source=notes.db;Version=3;";

        public EditPage()
        {
            InitializeComponent();
        }
        FirstPage newForm = new FirstPage();

        private void Button_Cancel(object sender, EventArgs e)
        {
            newForm.Show();
            this.Hide();
        
        }

        internal virtual void SetPlaceholderText(Control textBox, string hint)
        {
            if (textBox is TextBoxBase textControl) 
            {
                textControl.Text = hint;
                textControl.ForeColor = Color.Gray;

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
            textControl.Text = hint;
            textControl.ForeColor = Color.Gray;

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

            if ((text != "Enter your title here...") && (text2 != "Enter your note here..."))
            {
                SaveTextToDatabase(text, text2);

                //  (this.Owner as FirstPage)?.RetrieveDataFromDatabase();
                newForm.Show();

                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Please add a note or hit 'Cancel' to return", "Empty Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormClosed_(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        private void SaveTextToDatabase(string text, string text2)
        {
            bool rowsEqualTo12 = false;
            Properties.Settings.Default.displayedAddTip = true ;
            Properties.Settings.Default.Save();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Notes (Id INTEGER PRIMARY KEY AUTOINCREMENT, Text TEXT, Note TEXT)", connection))
                {
                    cmd.ExecuteNonQuery();

                }
                using (var countCommand = new SQLiteCommand("SELECT COUNT(*) FROM Notes", connection))
                {
                    int rowCount = Convert.ToInt32(countCommand.ExecuteScalar());
                    if (rowCount == 12)
                    {
                        rowsEqualTo12 = true;
                    }
                }
                if (rowsEqualTo12 is false)
                {
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = "INSERT INTO Notes (Text, Note) VALUES (@text, @text2)";
                        command.Parameters.AddWithValue("@text", text);
                        command.Parameters.AddWithValue("@text2", text2);
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Storage Full..", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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
