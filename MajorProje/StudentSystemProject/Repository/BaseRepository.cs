using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BaseRepository
    {
        private StudentSystemDBEntities studentSystemDBEntities;
        public StudentSystemDBEntities Model
        {
            get
            {
                if (studentSystemDBEntities is null)
                    studentSystemDBEntities = new StudentSystemDBEntities();
                return studentSystemDBEntities;
            }
        }
    }
}
