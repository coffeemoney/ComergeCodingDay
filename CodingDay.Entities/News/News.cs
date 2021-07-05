using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDay.Entities.News
{
    public class News
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

    }
}
