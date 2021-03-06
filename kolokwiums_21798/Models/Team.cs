using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium_21798.Models
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public int OrganizationID { get; set; }
        [Required]
        [MaxLength(50)]
        public string TeamName { get; set; }

        [MaxLength(500)]
        public string TeamDescription { get; set; }


        [ForeignKey("OrganizationID")]
        public virtual Organization Organization { get; set; }
        public virtual ICollection<File> Files { get; set; }
       
        public virtual ICollection<Membership> Membership { get; set; }
    }
}
