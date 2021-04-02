using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingOrganizerDesktopApp.Records;
using TeachingOrganizerDesktopApp.Repository;

namespace TeachingOrganizerDesktopApp.Service
{
    class CourseService
    {
        public static Course CreateCourseRecord(long studentID, string plan, int dateDay, int dateMonth, int dateYear, int startHour, int startMinute, int endHour, int endMinute)
        {
            var courseRecord = new Course();

            courseRecord.StudentID = studentID;
            courseRecord.Plan = plan;
            courseRecord.Duration = endHour-startHour + (decimal)(endMinute - startMinute >= 0 ? endMinute - startMinute : (endMinute - startMinute) * -1);
            courseRecord.DateDay = dateDay;
            courseRecord.DateMonth = dateMonth;
            courseRecord.DateYear = dateYear;
            courseRecord.StartHour = startHour;
            courseRecord.StartMinute = startMinute;
            courseRecord.EndHour = endHour;
            courseRecord.EndMinute = endMinute;

            return courseRecord;
        }

        public static string AddCourse(long studentID, string plan, int dateDay, int dateMonth, int dateYear, int startHour, int startMinute, int endHour, int endMinute)
        {
            string success = "Success";
            string invalidCourse = "CourseRecord is not valid";

            var courseRecord = CreateCourseRecord(studentID, plan, dateDay, dateMonth, dateYear, startHour, startMinute, endHour, endMinute);
            if (Validate.ValidCourse(courseRecord) == false)
            {
                return invalidCourse;
            }
            else
            {
                CourseRepository.AddCourse(courseRecord);
                return success;
            }
        }

        public static string UpdateCourse(long courseID, long studentID, string plan, int dateDay, int dateMonth, int dateYear, int startHour, int startMinute, int endHour, int endMinute)
        {
            string success = "Success";
            string invalidCourse = "CourseRecord is not valid";

            var courseRecord = CreateCourseRecord(studentID, plan, dateDay, dateMonth, dateYear, startHour, startMinute, endHour, endMinute);
            if (Validate.ValidCourse(courseRecord) == false)
            {
                return invalidCourse;
            }
            else
            {
                CourseRepository.UpdateCourse(courseID, courseRecord);
                return success;
            }
        }

        public static void DeleteCourse(long courseID)
        {
            CourseRepository.DeleteCourse(courseID);
        }

        public static Course GetCourse(long courseID)
        {
            return CourseRepository.GetCourse(courseID);
        }

        public static List<Course> GetListCourse()
        {
            return CourseRepository.GetListCourse();
        }
    }
}
