﻿using GigHub.Core.Models;
using System.Data.Entity;

namespace GigHub.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<Gig> Gigs { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<Attendance> Attendances { get; set; }
        DbSet<Following> Followings { get; set; }
        DbSet<Notification> Notifications { get; set; }
        DbSet<UserNotification> UserNotification { get; set; }
        IDbSet<ApplicationUser> Users { get; set; }
    }
}