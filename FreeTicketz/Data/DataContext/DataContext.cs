﻿using Microsoft.EntityFrameworkCore;

namespace FreeTicketz.Data.DataContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}
