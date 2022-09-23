using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.GraphQL.Types;
using WebApplication2.Repository;

namespace WebApplication2.Data.GraphQL
{
    public class CollegeMutation: ObjectGraphType
    {
        public CollegeMutation(StudentRepository repository)
        {
            base.Field<StudentType>(
                 "createStudent",
                 arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StudentInputType>> { Name = "name" }),
                 resolve: context =>
                 {
                     var student = context.GetArgument<StudentEntity>("name");
                     return repository.Post(student);
                 }
             );
        }
    }
}
