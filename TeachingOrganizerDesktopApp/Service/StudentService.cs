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
            var studentRecord = new Student() { FirstName = firstName,
                                                LastName = lastName,
                                                PhoneNumber = phoneNumber,
                                                RemainingSessions = remainingSessions,
                                                Details = details,
                                                Observations = observations
                                              };

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
            //return StudentRepository.GetStudent(studentID);

            return new Student() { FirstName = "Ana", LastName = "Ana", RemainingSessions = 2};
        }

        public static List<Student> GetListStudent()
        {
            //return StudentRepository.GetListStudent();

            var result = new List<Student>();
            var st1 = new Student() { FirstName = "Ana", LastName = "Ana", RemainingSessions = 2 };
            var st2 = new Student() { FirstName = "Ana2", LastName = "Ana2", RemainingSessions = 2 };
            result.Add(st1);
            result.Add(st2);
            return result;
        }
    }
}
