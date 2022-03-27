using _1911065227_BigSchool_NguyenHuyHoang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using _1911065227_BigSchool_NguyenHuyHoang.DTOs;

namespace _1911065227_BigSchool_NguyenHuyHoang.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userId
            };

            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
            {

                //_dbContext.Attendances.Remove(attendance);
                _dbContext.Entry(attendance).State = System.Data.Entity.EntityState.Deleted;
                _dbContext.SaveChanges();
                return Json(new { isFollow = false });
            }
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Json(new { isFollow = true });
        }

    }

}

