using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Data.Models
{
    [Table("Department", Schema = "dbo")]
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey(nameof(Instructor.Id))]
        public int InstructorId { get; set; }

        [Column(TypeName = "varchar(50)")]

        public string Name { get; set; }


        public DateTime Hiringdate { get; set; }

    }
}
