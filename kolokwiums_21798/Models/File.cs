using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium_21798.Models
{
    public class File
    {
        [Key]
        public int FileID { get; set; }
        public int TeamID { get; set; }
        [Required]
        [MaxLength(100)]
        public string FileName { get; set; }
        [Required]
        [MaxLength(4)]
        public string FileExtension { get; set; }
        [Required]
        public int FileSize { get; set; }
        [ForeignKey("TeamID")]
        public virtual Team Teams { get; set; }

    }
}
