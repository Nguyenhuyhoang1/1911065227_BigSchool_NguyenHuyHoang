﻿using _1911065227_BigSchool_NguyenHuyHoang.DTOs;
using _1911065227_BigSchool_NguyenHuyHoang.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace _1911065227_BigSchool_NguyenHuyHoang.Controllers
{

        public class FollowingsController : ApiController
        {
            private readonly ApplicationDbContext _dbContext;
            public FollowingsController()
            {
                _dbContext = new ApplicationDbContext();

            }
            [HttpPost]
            public IHttpActionResult Follow(FollowingDto followingDto)
            {
                var userId = User.Identity.GetUserId();
                var following = new Following
                {
                    FollowerId = userId,
                    FolloweeId = followingDto.FolloweeId
                };
                if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                {
                    _dbContext.Entry(following).State = System.Data.Entity.EntityState.Deleted;
                    _dbContext.SaveChanges();
                    return Json(new { isFollow = false, followeeId = followingDto.FolloweeId });
                }

                _dbContext.Followings.Add(following);
                _dbContext.SaveChanges();
                return Json(new { isFollow = true, followeeId = followingDto.FolloweeId });
            }

        }
    }
