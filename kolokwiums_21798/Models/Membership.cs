using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium_21798.Models
{
    public class Membership
    {
       
        
        public int MemberID { get; set; }
 
        public int TeamID { get; set; }

        [Required]
        public DateTime MembershipDate { get; set; }
        
        public virtual Member Member { get; set; }
        
        public virtual Team Team { get; set; }
    }
}
