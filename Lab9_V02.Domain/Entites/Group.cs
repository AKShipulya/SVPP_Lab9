using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_V02.Domain.Entites
{
    public class Group
    {
        public int GroupId { get; set; }
        public string CourseName { get; set; }
        public DateTime Commence { get; set; }
        public decimal BasePrice { get; set; }
        // навигационное свойство
        public ICollection<Student> Students { get; set; }
    }
}
