using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QamatzWebsite.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        [Column(TypeName = "text")]
        public string? Description { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Author { get; set; }

        public Tag? Tag { get; set; }
    }
}
