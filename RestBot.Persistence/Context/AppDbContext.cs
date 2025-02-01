using Microsoft.EntityFrameworkCore;
using RestBot.Domain.Entities;

namespace Persistence.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    public DbSet<Reservation> Reservations { get; set; }
}
