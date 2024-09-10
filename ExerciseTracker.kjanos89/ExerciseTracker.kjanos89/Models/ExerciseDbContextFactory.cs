﻿using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.kjanos89.Models
{
    public class ExerciseDbContextFactory : IDesignTimeDbContextFactory<ExerciseDbContext>
    {
        public ExerciseDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ExerciseDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=Exercises;Integrated Security=True;TrustServerCertificate=True;");

            return new ExerciseDbContext(optionsBuilder.Options);
        }
    }
}