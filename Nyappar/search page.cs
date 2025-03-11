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
    public partial class search_page : Form
    {
        private List<Book> books = new List<Book>
    {
        new Book("The Great Gatsby", "F. Scott Fitzgerald", "123456"),
        new Book("To Kill a Mockingbird", "Harper Lee", "789012"),
        new Book("1984", "George Orwell", "345678"),
        new Book("Moby Dick", "Herman Melville", "901234"),
        new Book("Pride and Prejudice", "Jane Austen", "567890")
    };
        public search_page()
        {
            InitializeComponent();
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            dgvResults.DataSource = books; // Load all books initially
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }

            public Book(string title, string author, string isbn)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }
        }
    }
}
