using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingOrganizerDesktopApp.Records;
using TeachingOrganizerDesktopApp.Repository;

namespace TeachingOrganizerDesktopApp.Service
{
    class StudentService
    {
        public static Student CreateStudentRecord(string firstName, string lastName, string phoneNumber, int remainingSessions, string details, string observations)
        {
            var studentRecord = new Student();

            studentRecord.FirstName = firstName;
            studentRecord.LastName = lastName;
            studentRecord.PhoneNumber = phoneNumber;
            studentRecord.RemainingSessions = remainingSessions;
            studentRecord.Details = details;
            studentRecord.Observations = observations;

            return studentRecord;
        }

        public static string AddStudent(string firstName, string lastName, string phoneNumber, int remainingSessions, string details, string observations)
        {
            string success = "Success";
            string invalidStudent = "StudentRecord is not valid";

            var studentRecord = CreateStudentRecord(firstName, lastName, phoneNumber, remainingSessions, details, observations);
            if(Validate.ValidStudent(studentRecord) == false)
            {
                return invalidStudent;
            }
            else
            {
                StudentRepository.AddStudent(studentRecord);
                return success;
            }
        }

        public static string UpdateStudent(long studentID, string firstName, string lastName, string phoneNumber, int remainingSessions, string details, string observations)
        {
            string success = "Success";
            string invalidStudent = "StudentRecord is not valid";

            var studentRecord = CreateStudentRecord(firstName, lastName, phoneNumber, remainingSessions, details, observations);
            if (Validate.ValidStudent(studentRecord) == false)
            {
                return invalidStudent;
            }
            else
            {
                StudentRepository.UpdateStudent(studentID, studentRecord);
                return success;
            }
        }

        public static void DeleteStudent(long studentID)
        {
            StudentRepository.DeleteStudent(studentID);
        }

        public static Student GetStudent(long studentID)
        {
            return StudentRepository.GetStudent(studentID);
        }

        public static List<Student> GetListStudent()
        {
            return StudentRepository.GetListStudent();
        }
    }
}
