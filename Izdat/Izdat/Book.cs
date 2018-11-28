using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izdat
{
    public enum BookSubType
    {
        prosa,
        story,
        poetry
    }

    public enum Genre
    {
        historical,
        fantasy,
        roman,
        detective
    }

    public class BookType
    {      
        private Genre genre;
        private BookSubType bookType;

        public BookType (Genre genre, BookSubType bookType)
        {
            this.genre = genre;
            this.bookType = bookType;
        }
    }
}
