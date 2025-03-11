using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nyappar
{
    public partial class bookdetails: Form
    {
        public bookdetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = lblTitle.Text;
            string author = lblAuthor.Text;
            string isbn = lblISBN.Text;
            string publisher = lblPublisher.Text;

            MessageBox.Show($"Book Saved:\nTitle: {title}\nAuthor: {author}\nISBN: {isbn}\nPublisher: {publisher}", "Success");
        }

        private void grpBookdetails_Enter(object sender, EventArgs e)
        {

        }

        private void txtPublishes_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grpBookDetails.Controls)
            {
                if (ctrl is TextBox txtBox)
                {
                    txtBox.Clear();
                }
            }

           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
