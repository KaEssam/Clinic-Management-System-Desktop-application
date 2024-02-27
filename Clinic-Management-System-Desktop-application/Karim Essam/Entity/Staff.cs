using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_test
{
    internal class Staff
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }

        [Required]
        [StringLength(50)]
        public string StaffName { get; set; }

        [Required]
        [StringLength(11)]
        public string StaffPhone { get; set; }

        [Required]
        public string StaffUserName { get; set; }

        [Required]
        public string StaffPassword { get; set; }

        public string StaffRole { get; set; }

        public string StaffAddress { get; set; }

    }
}