using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingOrganizerDesktopApp.Records
{
    class Student
    {
        public long StudentID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int RemainingSessions { get; set; } = 0;

        public string Details { get; set; } = string.Empty;
        public string Observations { get; set; } = string.Empty;
    }
}
