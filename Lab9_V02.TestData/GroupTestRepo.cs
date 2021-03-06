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
    class GroupTestRepo : IRepository<Group>
    {
        /// <summary>
        /// Список групп для тестирования прилождения
        /// </summary>
        private readonly List<Group> groups;
        public GroupTestRepo(List<Group> groups)
        {
            this.groups = groups;
            SetupData(); // сгенерировать тестовые данные
        }
        /// <summary>
        /// Метод, генерирующий тестовые данные
        /// </summary>
        private void SetupData()
        {
            var s = 1;
            Random rnd = new Random();
            for (var i = 1; i <= 5; i++)
            {
                var group = new Group
                {
                    BasePrice = rnd.Next(1000, 5000),
                    Commence = DateTime.Now +

                TimeSpan.FromDays(rnd.Next(10, 20)),
                    CourseName = $"Группа {i}",
                    GroupId = i
                };
                var students = new List<Student>();
                for (var j = 0; j < 10; j++)
                {
                    students.Add(new Student
                    {
                        GroupId = i,

                        DateOfBirth = DateTime.Now -

                    TimeSpan.FromDays(rnd.Next(6000, 20000)),
                        FullName = $"Студент {s}",
                        StudentId = s,
                        IndividualPrice =

                    (decimal)((double)group.BasePrice * rnd.NextDouble())
                    });
                    s++;
                }
                group.Students = students;
                groups.Add(group);
            }
        }
        public void Create(Group entity)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int id)
        {
            return true;
        }
        public IQueryable<Group> Find(Expression<Func<Group, bool>>
        predicate)
        {
            throw new NotImplementedException();
        }
        public Group Get(int id, params string[] includes)
        {
            return groups.FirstOrDefault(g => g.GroupId == id);
        }
        public IQueryable<Group> GetAll()
        {
            return groups.AsQueryable();
        }
        public void Update(Group entity)
        {
        }
    }
}


