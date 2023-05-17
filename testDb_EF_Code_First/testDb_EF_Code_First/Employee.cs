using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDb_EF_Code_First
{
    [Table("Employee")]
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Employee_PK { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int EmpCode { get; set; }
        [Required]
        public int Gender { get; set; }
        [Required]
        public System.DateTime DOB { get; set; }
        public Nullable<decimal> Salary { get; set; }
        [Required]
        public System.DateTime JoiningDate { get; set; }
        public Nullable<System.DateTime> ResignDate { get; set; }
    }
}
