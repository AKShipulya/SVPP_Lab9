using Lab9_V02.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_V02.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Student> StudentsRepository { get; }
        IRepository<Group> GroupsRepository { get; }

        void SaveChanges();
    }
}
