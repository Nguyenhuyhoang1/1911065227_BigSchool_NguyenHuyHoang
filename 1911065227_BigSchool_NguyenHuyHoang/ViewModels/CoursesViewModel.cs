using _1911065227_BigSchool_NguyenHuyHoang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1911065227_BigSchool_NguyenHuyHoang.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }

        public IEnumerable<Attendance> IsFollowCourses { get; set; }
        public IEnumerable<Following> IsFollowLecturers { get; set; }
    }
}