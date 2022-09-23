using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.GraphQL.Types;
using WebApplication2.Repository;

namespace WebApplication2.Data.GraphQL
{
    public class CollegeQuery: ObjectGraphType
    {
        public CollegeQuery(StudentRepository repository)
        {
            Field<ListGraphType<StudentType>>("students",
                resolve: context => repository.Get());

            /*Field<ListGraphType<StudentType>>("getStudentById",
                resolve: context => repository.Get());*/



        }

    }
   

    
}
