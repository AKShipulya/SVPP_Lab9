using Lab9_V02.DAL.Data;
using Lab9_V02.Domain.Entites;
using Lab9_V02.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_V02.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly CourcesContext context;
        private IRepository<Student> studentsRepository;
        private IRepository<Group> groupsRepository;
        public EFUnitOfWork(string connectionString)
        {
            var options = new
            DbContextOptionsBuilder<CourcesContext>()
            .UseSqlServer(connectionString)
            .Options;
            context = new CourcesContext(options);
            context.Database.EnsureCreated();
        }
        public IRepository<Student> StudentsRepository =>
        studentsRepository ?? new EfStudentRepository(context);
        public IRepository<Group> GroupsRepository =>
        groupsRepository ?? new EfGroupsRepository(context);
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
