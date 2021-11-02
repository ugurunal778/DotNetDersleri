using EntityFrameworkCodeFirstSample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolContext dataEntity = new SchoolContext();
            Student student = new Student();
            student.StudentName = "Akça";

            student.DateOfBirth = new DateTime(1989, 4, 9);
            dataEntity.Student.Add(student);
            dataEntity.SaveChanges();


            var students = dataEntity.Student.ToList();

            dataEntity.Student.Remove(student);
            dataEntity.SaveChanges();

            var ercan = students.FirstOrDefault(x => x.StudentName == "Ercan");
            ercan.StudentName = "Levent";
            dataEntity.SaveChanges();

        }
    }
}
