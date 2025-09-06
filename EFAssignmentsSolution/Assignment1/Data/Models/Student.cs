using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Data.Models
{
    internal class Student
    {
      //PM> Add-Migration AddStudentTable -Context ITIyDbContext -OutputDir Data/Migrations

        public int Id { get; set; }
        public string? Fname { get; set; }
        public string Lname { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }
         



    }
}
