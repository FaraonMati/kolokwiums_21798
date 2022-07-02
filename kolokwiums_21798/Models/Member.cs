using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium_21798.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }
       
        public int OrganizationID { get; set; }
        [Required]
        [MaxLength(20)]
        public string MemberName { get; set; }
        [Required]
        [MaxLength(50)]
        public string MemberSureName { get; set; }

        [MaxLength(20)]
        public string MemberNickName { get; set; }
        [ForeignKey("OrganizationID")]
        public virtual Organization Organization { get; set; }
        
        public virtual ICollection<Membership> Membership{ get; set; }
    }
}
