using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jabin_Choi_Excercise01
{
    public partial class Excercise01 : Form
    {
        public Excercise01()
        {
            InitializeComponent();
        }

        private void Excercise01_Load(object sender, EventArgs e)
        {
            // Entity Framework Dbcontext
            var dbcontext = new BookExamples.BooksEntities();

            // Ex01 - 1.
            // Get a list of all the titles and the authors who wrote them. Sort the results by title
            // Get authors and titles of each book
            var authorAndTitles =
                from book in dbcontext.Titles
                from author in book.Authors
                select new { author.FirstName, author.LastName, book.Title1 };

            outputTextBox.AppendText("\r\n\r\nAuthors and titles:");

            // Display authors and titles in tabular format
            foreach (var element in authorAndTitles)
            {
                outputTextBox.AppendText($"\r\n\t{element.FirstName,-10} " +
               $"{element.LastName,-10} {element.Title1}");
            }


            // Ex01 - 2.
            // Get a list of all the titles and the authors who wrote them. Sort the results by title. Each title sort the authors
            // alphabetically by last name, then first name.
            // Get authors and titles of each books sorted alphabetically by author's last name and then first name
            var sortedAuthorAndTitles =
                from book in dbcontext.Titles
                from author in book.Authors
                orderby author.LastName, author.FirstName
                select new { author.FirstName, author.LastName, book.Title1 };

            outputTextBox.AppendText("\r\n\r\nAuthors and titles sorted alphabetically by author's last name and then first name:");

            // Display sorted results of authors and titles in tabular format
            foreach(var element in sortedAuthorAndTitles)
            {
                outputTextBox.AppendText($"\r\n\t{element.FirstName,-10} " +
               $"{element.LastName,-10} {element.Title1}");
            }


            // Ex01 - 3.
            // Get a list of all the authors grouped by title, sorted by title; for a given title sort the author names
            // alphabetically by last name then first name.
            var authorsByTitle =
                from book in dbcontext.Titles
                select new
                {
                    Titles = book.Title1,
                    Name =
                        from author in book.Authors
                        orderby author.FirstName, author.LastName
                        select new { author.FirstName, author.LastName }
                };

            outputTextBox.AppendText("\r\n\r\nAuthors grouped by title:");

            // Display authors grouped by title
            foreach(var title in authorsByTitle)
            {
                outputTextBox.AppendText($"\r\n\t{title.Titles}");
                foreach (var author in title.Name)
                {
                    outputTextBox.AppendText($"\r\n\t\t{author}");
                }
            }
        }
    }
}
