using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAPI.Models
{
    [Table("mark")]
    public class MarkModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set;}

        [Required]
        public int score { get; set;}


        [Required]
        public int studentId { get; set;}
    }
}
