using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB.Model
{
    public class ModelMapping
    {
        public Student LoadStudent(AddressBookDB.Student stu)
        {
            return new Student
            {
                StudentId = stu.Student_id,
                Name = stu.Name,
                Address = stu.Address,
                ImageUrl = stu.Image
            };

        }

        public Student GetStudent(AddressBookDB.Student stu)
        {
            return new Student
            {
                StudentId = stu.Student_id,
                Name = stu.Name,
                Address = stu.Address,
                ImageUrl = stu.Image

            };
        }

        public Teacher LoadTeacher(AddressBookDB.Teacher tea)
        {
            return new Teacher
            {
                TeacherId = tea.Teacher_id,
                Name = tea.Name,
                Address = tea.Address,
                ImageUrl = tea.Image
            };

        }
        public Teacher GetTeacher(AddressBookDB.Teacher tea)
        {
            return new Teacher
            {
                TeacherId = tea.Teacher_id,
                Name = tea.Name,
                Address = tea.Address,
                ImageUrl = tea.Image
            };

        }
    }
}
