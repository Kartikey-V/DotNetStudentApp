using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data.GraphQL.Types
{
    public class StudentInputType: InputObjectGraphType 
    {
        public StudentInputType()
        {
            Name = "studentInput";
            base.Field<NonNullGraphType<StringGraphType>>("name");
        }
    }
}
