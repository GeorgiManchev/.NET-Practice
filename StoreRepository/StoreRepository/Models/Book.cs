using StoreRepository.Utils;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreRepository.Models
{
    public class Book
    {
        public Book()
        {
            this.Authors = new SortedSet<Author>();
        }

        [Key]
        public int Id { get; set; }

        [Required, StringLength(50, MinimumLength = 2)]
        public string Title { get; set; }

        [Required, StringLength(2, MinimumLength = 2)]
        public string Language { get; set; }

        [Required, Range(minimum: 1, maximum: 2000)]
        public int Pages { get; set; }

        [EnumDataType(typeof(Genre))]
        public Genre InGenre { get; set; }

        public virtual ICollection<Author> Authors { get; set; }

        public virtual Offer BookOffer { get; set; }
    }
}
