﻿using OpenShelter.Models;
using OpenShelter.Services;

[assembly: Xamarin.Forms.Dependency(typeof(AttendanceRepository))]
namespace OpenShelter.Services
{
    public class AttendanceRepository : GenericRepository<Attendance>, IAttendanceRepository
    {
    }
}
