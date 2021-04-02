using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingOrganizerDesktopApp.Records
{
    public class Course
    {
        public long CourseID { get; set; }
        public long StudentID { get; set; } = 0;
        public string Plan { get; set; } = string.Empty;
        public decimal Duration { get; set; } = 0;
        public int DateDay { get; set; } = 0;
        public int DateMonth { get; set; } = 0;
        public int DateYear { get; set; } = 0;
        public int StartHour { get; set; } = -1;
        public int StartMinute { get; set; } = -1;
        public int EndHour { get; set; } = -1;
        public int EndMinute { get; set; } = -1;
    }
}
