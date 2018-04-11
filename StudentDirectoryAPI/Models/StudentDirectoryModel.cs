using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDirectoryAPI.Models
{
    public class StudentDirectoryModel : DbContext
    {

        public StudentDirectoryModel(DbContextOptions<StudentDirectoryModel>options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

    }
}
