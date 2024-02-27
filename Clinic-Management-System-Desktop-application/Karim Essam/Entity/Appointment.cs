using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace database_test
{
    internal class Appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentId { get; set; }

        [Required]
        public DateTime AppointmenDate { get; set; }

        [ForeignKey("Staff")]
        public int? StaffId { get; set; }

        public Staff Staff { get; set; }

    }
}