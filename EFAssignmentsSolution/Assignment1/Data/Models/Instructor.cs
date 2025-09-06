using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Data.Models
{
    [Table("Instructor", Schema = "dbo")]

    internal class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey(nameof(Department.Id))]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage ="Name Is Required")]
        public string Name { get; set; }
        public decimal Bonus { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public DateTime HourDate { get; set; }



    }
}
