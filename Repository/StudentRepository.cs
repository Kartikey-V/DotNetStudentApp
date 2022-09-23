using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;

namespace WebApplication2.Repository
{
    public class StudentRepository
    {

        public CollegeDbContext _dbContext;
       public IEnumerable<StudentEntity> StudentEntiities { get; set; }

        public StudentRepository(CollegeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        


        public IEnumerable<StudentEntity> Get()
        {
            return _dbContext.StudentEntiities;
        }

        public StudentEntity Post(StudentEntity student)
        {
            this._dbContext.StudentEntiities.Add(student);
            this._dbContext.SaveChanges();
            return this._dbContext.StudentEntiities.First(s => s.Name == student.Name);
        }
    }
}
