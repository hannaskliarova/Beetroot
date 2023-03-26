using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Teacher
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Subject { get; set; }

        public Teacher (string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public void UpdateTeacher(Teacher teacherToUpdate, string newFirstName, string newLastName, string newSubject)
        {
            teacherToUpdate.FirstName = newFirstName;
            teacherToUpdate.LastName = newLastName;
            teacherToUpdate.Subject = newSubject;

        }
    }
}
