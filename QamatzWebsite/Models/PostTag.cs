using System.ComponentModel.DataAnnotations;

namespace QamatzWebsite.Models
{
    public class PostTag
    {
        [Key]
        public int PostId { get; set; }

        public int TagId { get; set; }
    }
}
