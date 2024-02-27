using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace database_test
{
    internal class Prescription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PrescriptionId { get; set; }

        [Required]
        [StringLength(50)]
        public string PrescriptionName { get; set; }

        [Required]
        public string PrescriptionType { get; set; }

        public string PrescriptionNotes { get; set; }

    }
}