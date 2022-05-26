using Lab9_V02.Domain.Entites;
using Lab9_V02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_V02_Business.Managers
{
    public class BaseManager
    {
        protected readonly IUnitOfWork unitOfWork;
        protected readonly IRepository<Student> studentRepository;
        protected readonly IRepository<Group> groupRepository;
        public BaseManager(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            studentRepository = unitOfWork.StudentsRepository;
            groupRepository = unitOfWork.GroupsRepository;
        }
    }
}
