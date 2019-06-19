using AcademySystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademySystem.Context
{
    public class ContextAcademy:DbContext
    {
        public ContextAcademy(DbContextOptions<ContextAcademy> options)
            :base(options)
        {}

        public DbSet<Professor> professor {get;set;}

    }
}
