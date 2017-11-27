using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreRepository.Models
{
    public class Author
    {
        public Author()
        {
            this.Books = new SortedSet<Book>();
        }

        public int Id { get; set; }

        [Required, StringLength(64, MinimumLength = 4)]
        public string FullName { get; set; }

        [StringLength(1024)]
        public string Bio { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }   
}
