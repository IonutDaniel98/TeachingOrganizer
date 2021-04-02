using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingOrganizerDesktopApp.Records;

namespace TeachingOrganizerDesktopApp.Repository
{
    class CourseRepository
    {
        public static void AddCourse(Course courseRecord)
        {

        }

        public static void UpdateCourse(long courseID, Course courseRecord)
        {

        }

        public static void DeleteCourse(long courseID)
        {

        }

        public static Course GetCourse(long courseID)
        {
            var courseRecord = new Course();

            return courseRecord;
        }

        public static List<Course> GetListCourse()
        {
            var courseRecords = new List<Course>();

            return courseRecords;
        }
    }
}
