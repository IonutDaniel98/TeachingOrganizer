using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingOrganizerDesktopApp.Records
{
    class Validate
    {
        #region Student

        public static bool ValidStudent(Student studentRecord)
        {
            if (studentRecord.FirstName == string.Empty ||
                studentRecord.LastName == string.Empty ||
                studentRecord.PhoneNumber == string.Empty)
            {
                return false;
            }
            return true;
        }

        #endregion Student

        #region Course

        public static bool ValidCourse(Course courseRecord)
        {
            if (courseRecord.StudentID == 0 ||
                courseRecord.DateDay == 0 ||
                courseRecord.DateMonth == 0 ||
                courseRecord.DateYear == 0 ||
                courseRecord.StartHour == -1 ||
                courseRecord.StartMinute == -1 ||
                courseRecord.EndHour == -1 ||
                courseRecord.EndMinute == -1)
            {
                return false;
            }
            return true;
        }

        #endregion Course
    }
}
