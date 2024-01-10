using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMgr.Models
{
    public class GraduationTopic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Topic { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
        public float Grade { get; set; }

        public int StudentId { get; set; }
        public int SupervisorId { get; set; }

        // Navigation properties
        public virtual User Student { get; set; }
        public virtual User Supervisor { get; set; }

    }
}
