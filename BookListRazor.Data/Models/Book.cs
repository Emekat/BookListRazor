using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookListRazor.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Book Name")]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string ISBN { get; set; }
    }
}
