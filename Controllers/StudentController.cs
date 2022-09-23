using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly StudentRepository _repo;

        /*public List<Student> students = new List<Student>() {
            new Student(){Id = 1, Name = "K", Age=11},
            new Student(){Id = 2, Name = "R", Age=20},
            new Student(){Id = 3, Name = "T", Age=19},
            new Student(){Id = 4, Name = "I", Age=25},
            new Student(){Id = 5, Name = "K", Age=18},
            new Student(){Id = 6, Name = "E", Age=23},
            new Student(){Id = 7, Name = "Y", Age=16}
        };*/


        public StudentController(StudentRepository _StudentRepo)
        {
            this._repo = _StudentRepo;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<StudentEntity> Get()
        {
            /*var result = from s in students
                         where s.Age >= 18 && s.Age <= 25
                         select s;
            //return students.Select();
            Console.WriteLine("HEllO Re");
            foreach (var s in students)
            {
                yield return s;
            }*/
            return _repo.Get();
        }

        // GET api/<StudentController>/5
        /* [HttpGet("{id}")]
         public StudentEntity Get(int id)
         {
             var idx = dbContext.StudentEntiities.First(s => s.Id == id);
             return idx;
         }

         // POST api/<StudentController>
         [HttpPost]
         public IEnumerable<StudentEntity> Post(StudentEntity s)
         {
             var ns = new StudentEntity()
             {
                 Name = s.Name,
                 Age = s.Age

             };
             dbContext.StudentEntiities.Add(ns);
             dbContext.SaveChanges();
             return dbContext.StudentEntiities;

         }

         // PUT api/<StudentController>/5
         [HttpPut("{id}")]
         public IEnumerable<StudentEntity> Put(int id, StudentEntity value)
         {
            *//* var idx = dbContext.Find(id);*//*

             var idx = dbContext.StudentEntiities.First(s => s.Id == id);
             idx.Name = value.Name;
             dbContext.SaveChanges();
             return dbContext.StudentEntiities;
         }

         // DELETE api/<StudentController>/5
         [HttpDelete("{id}")]
         public IEnumerable<StudentEnti*/
        /*ty> Delete(int id)
        {
            var idx = dbContext.StudentEntiities.Find(id);
            dbContext.Remove(idx);
            dbContext.SaveChanges();
            return dbContext.StudentEntiities;
        }*/
    }
}
