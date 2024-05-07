using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAPI.Models
{
    [Table("subject")]
    public class SubjectModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set;}

        [Required]
        public string subject { get; set;}

    }
}
