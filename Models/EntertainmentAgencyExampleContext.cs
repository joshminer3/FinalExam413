using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Final.Models
{
    public partial class EntertainmentAgencyExampleContext : DbContext
    {
        public EntertainmentAgencyExampleContext()
        {
        }

        public EntertainmentAgencyExampleContext(DbContextOptions<EntertainmentAgencyExampleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Entertainers> Entertainers { get; set; }


    }
}
