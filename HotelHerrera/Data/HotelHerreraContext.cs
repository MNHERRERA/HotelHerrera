using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelHerrera.Models;

namespace DBSqlHotelHerrera.Data
{
    public class HotelHerreraContext : DbContext
    {
        public HotelHerreraContext (DbContextOptions<HotelHerreraContext> options)
            : base(options)
        {
        }

        public DbSet<HotelHerrera.Models.Clientes> Clientes { get; set; } = default!;
        public DbSet<HotelHerrera.Models.PlanDeRecompensas> PlanDeRecompensas { get; set; } = default!;
        public DbSet<HotelHerrera.Models.Reserva> Reserva { get; set; } = default!;
    }
}
