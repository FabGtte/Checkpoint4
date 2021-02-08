using System;
using System.Collections.Generic;
using Checkpoint4.Models;
using Microsoft.EntityFrameworkCore;

public class UniteLegaleContext : DbContext
{
    public DbSet<WordToPassword> WordToPasswords { get; set; }

    public DbSet<GeneratedPassword> GeneratedPasswords { get; set; }
    public UniteLegaleContext(DbContextOptions<UniteLegaleContext> options)
    : base(options)
    {
    }
}

