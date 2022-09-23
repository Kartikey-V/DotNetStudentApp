using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data
{
    public static class InitialData
    {
        public static void Seed(this CollegeDbContext DbContext)
        {
            if (!DbContext.StudentEntiities.Any())
            {
                DbContext.StudentEntiities.Add(new StudentEntity
                {
                    Name = "Kartikey",
                    Age = 22
                });
                DbContext.StudentEntiities.Add(new StudentEntity
                {
                    Name = "John",
                    Age = 21
                });
                DbContext.StudentEntiities.Add(new StudentEntity
                {
                    Name = "Rajat",
                    Age = 19
                });
                DbContext.StudentEntiities.Add(new StudentEntity
                {
                    Name = "Jack",
                    Age = 18
                });
                DbContext.StudentEntiities.Add(new StudentEntity
                {
                    Name = "Naruto",
                    Age = 29
                });
                DbContext.SaveChanges();
            }
        }
    }
}
