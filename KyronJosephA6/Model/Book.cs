using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyronJosephA6.Model
{
    /// <summary>
    /// this class will create a book object
    /// </summary>
    public class Book
    {
        public String? Title { get; set; }

        public String? Author { get; set; }

        public int? PageLength { get; set; }

        public String? Genre { get; set; }

        public int? YearPublished { get; set; }

        public double? MSRP { get; set; }

        /// <summary>
        /// 5 paremeter constructor for book class
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Author"></param>
        /// <param name="PageLength"></param>
        /// <param name="Genre"></param>
        /// <param name="YearPublished"></param>
        /// <param name="MSRP"></param>
        public Book(String Title, String Author, int PageLength, String Genre, int YearPublished, double MSRP)
        {
            this.Title = Title;
            this.Author = Author;
            this.PageLength = PageLength;
            this.Genre = Genre;
            this.YearPublished = YearPublished;
            this.MSRP = MSRP;
        }

    }
}
