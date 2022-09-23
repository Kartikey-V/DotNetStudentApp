using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data.GraphQL.Types
{
    public class StudentType: ObjectGraphType<StudentEntity>
    {
        public StudentType()
        {
            base.Field(t => t.Id);
            base.Field(t => t.Name);
        }

    }
}
