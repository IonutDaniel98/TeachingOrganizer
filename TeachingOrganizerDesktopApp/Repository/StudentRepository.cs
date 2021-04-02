using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingOrganizerDesktopApp.Records;

namespace TeachingOrganizerDesktopApp.Repository
{
    class StudentRepository
    {
        public static void AddStudent(Student studentRecord)
        {
            SqliteDataAccess.SaveStudent(studentRecord);
        }

        public static void UpdateStudent(long studentID, Student studentRecord)
        {

        }

        public static void DeleteStudent(long studentID)
        {

        }

        public static Student GetStudent(long studentID)
        {
            var studentRecord = new Student();

            return studentRecord;
        }

        public static List<Student> GetListStudent()
        {
            var studentRecords = new List<Student>();

            return studentRecords;
        }
    }
}
