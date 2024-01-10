using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMgr.Models
{
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public GenderType Gender { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public RoleType Role { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }

        // Navigation properties
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Research> Researches { get; set; }
        public virtual GraduationTopic GraduationTopic { get; set; }
        public virtual ICollection<GraduationTopic> SupervisedTopics { get; set; }


        public User Clone()
        {
            return (User)this.MemberwiseClone();
        }
    }
    public enum RoleType
    {
        [Display(Name = "Giảng viên")]
        Lecturer = 0,
        [Display(Name = "Nghiên cứu sinh")]
        Postgraduate = 1,
        [Display(Name = "Sinh viên")]
        Student = 2
    }
    public enum GenderType
    {
        [Display(Name = "Nam")]
        Male = 0,
        [Display(Name = "Nữ")]
        Female = 1
    }
}
