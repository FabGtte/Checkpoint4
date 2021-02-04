using System;
using System.Collections.Generic;
using Checkpoint4.Models;
using Microsoft.EntityFrameworkCore;

public class UniteLegaleContext : DbContext
{
    public DbSet<OldPassword> OldPasswords { get; set; }

    public DbSet<NewPassword> NewPasswords { get; set; }
    public UniteLegaleContext(DbContextOptions<UniteLegaleContext> options)
    : base(options)
    {
    }
}

