using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sticky_Notes_App
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void First_Load(object sender, EventArgs e)
        {

        }

        private void Button_add(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();

            // Show the new form
            newForm.Show();
            this.Hide();


        }      
        

    }
}
