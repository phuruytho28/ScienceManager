using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMgr.Models
{
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Abstract { get; set; }
        [Required]
        [MaxLength(500)]
        public string Keywords { get; set; }
        public DateTime SubmissionDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string SubmisstionAt { get; set; }

        // Navigation properties
        public virtual ICollection<User> Authors { get; set; }
    }
}
