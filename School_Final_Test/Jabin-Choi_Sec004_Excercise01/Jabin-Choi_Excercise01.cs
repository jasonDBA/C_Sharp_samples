using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jabin_Choi_Sec004_Excercise01
{
    public partial class Excercise01 : Form
    {
        public Excercise01()
        {
            InitializeComponent();
        }

        private void Excercise01_Load(object sender, EventArgs e)
        {
            var dbcontext = new BooksExamples.BooksEntities();

            // Ex01 - a.
            // Get a count of all the authors grouped by title, sorted by title.
            var authorsByTitle =
                from book in dbcontext.Titles
                orderby book.Title1
                select new
                {
                    Titles = book.Title1,
                    Count =
                        (from author in book.Authors
                         select author).Count()
                };

            // Display a title and number of authors who have written that title.
            outputTextBox.AppendText("\r\n\r\nBook Title and the number of authors:");
            foreach (var title in authorsByTitle)
            {
                outputTextBox.AppendText($"\r\n\t{title.Titles}\r\n\t\tThe number of authors = {title.Count}\n");
            }



            // Ex01 - b.
            // Get a list of all the titles grouped by author name, sorted by author
            var titleByAuthor =
                from author in dbcontext.Authors
                orderby author.FirstName, author.LastName
                select new
                {
                    AuthorFirstName = author.FirstName,
                    AuthorLastName = author.LastName,
                    Title =
                        from book in author.Titles
                        orderby book.Title1
                        select book.Title1
                };


            // Display the result
            outputTextBox.AppendText("\r\n\r\n\r\n Author name and Book title grouped by author name:");
            foreach(var author in titleByAuthor)
            {
                outputTextBox.AppendText($"\r\n\t{author.AuthorFirstName}, {author.AuthorLastName}");
                foreach(var title in author.Title)
                {
                    outputTextBox.AppendText($"\r\n\t\t{title}");
                }
            }
        }
    }
}
