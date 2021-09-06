using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NotDefterimMVC.Data
{
    public class Note
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Title { get; set; }
        public string Content { get; set; }
        [ForeignKey("Author")]
        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
    }
}
