using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_test
{
    internal class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }

        [Required]
        [StringLength(50)]
        public string PatientName { get; set; }

        [Required]
        [StringLength(11)]
        public string PatientPhone { get; set; }

        [Required]
        public string PatientAddress { get; set; }

        public string PatientGender { get; set; }

        [Required]
        public int PatientAge { get; set; }

        public string PatientMaritalStatus { get; set; }
        public bool done {  get; set; }

        public DateTime appointments { get; set; }

    }
}