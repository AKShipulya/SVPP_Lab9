using Lab9_V02.Domain.Entites;
using Lab9_V02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_V02.TestData
{
    class StudentTestRepo : IRepository<Student>
    {
        private readonly List<Student> students;
        public StudentTestRepo(List<Student> students)
        {
            this.students = students;
        }
        public void Create(Student entity)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
        public IQueryable<Student> Find(Expression<Func<Student, bool>> predicate)
        {
            Func<Student, bool> filter = predicate.Compile();
            return students.Where(filter).AsQueryable();
        }
        public Student Get(int id, params string[] includes)
        {
            throw new NotImplementedException();
        }
        public IQueryable<Student> GetAll()
        {
            throw new NotImplementedException();
        }
        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}

