using Lab9_V02.DAL.Repositories;
using Lab9_V02.Domain.Interfaces;
using Lab9_V02.TestData;
using Lab9_V02_Business.Managers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_V02_Business.Infrastructure
{
    public class ManagersFactory
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly StudentManager studentManager;
        private readonly GroupManager groupManager;

        public ManagersFactory(string connStringName)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var connString = configuration.GetConnectionString(connStringName);

            unitOfWork = new EFUnitOfWork(connString);
        }

        public StudentManager GetSudentManager()
        {
            return studentManager ?? new StudentManager(unitOfWork);
        }
        public GroupManager GetGroupManager()
        {
            return groupManager ?? new GroupManager(unitOfWork);
        }
    }
}
