using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data
{
    public class StudentEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public String Name { get; set; }
        public int Age { get; set; }
    }
}
