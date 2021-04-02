using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingOrganizerDesktopApp.Records;

namespace TeachingOrganizerDesktopApp.Repository
{
    public class SqliteDataAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        #region Student

        public static List<Student> LoadStudents()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var result = cnn.Query<Student>("SELECT * from StudentTable", new DynamicParameters());
                return result.ToList();
            }
        }

        public static void SaveStudent(Student studentRecord)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into StudentTable (FirstName, LastName, PhoneNumber, RemainingSessions, Details, Observations) values (@FirstName, @LastName, @PhoneNumber, @RemainingSessions, @Details, @Observations)", studentRecord);
            }
        }

        #endregion Student

        #region Course

        public static List<Course> LoadCourses()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var result = cnn.Query<Course>("SELECT * from CourseTable", new DynamicParameters());
                return result.ToList();
            }
        }

        public static void SaveCourse(Course courseRecord)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into CourseTable (StudentId, Dateday, DateMonth, DateYear, StartHour, StartMinute, EndHour, EndMinute, Duration) values (@StudentID, @DateDay, @DateMonth, @DateYear, @StartHour, @StartMinute, @EndHour, @EndMinute, @Duration)", courseRecord);
            }
        }

        #endregion Course
    }
}
