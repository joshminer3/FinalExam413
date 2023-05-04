using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class EFEntertainersRepository : IEntertainersRepository
    {
        private EntertainmentAgencyExampleContext EntContext { get; set; }


        public EFEntertainersRepository (EntertainmentAgencyExampleContext temp)
        {
            EntContext = temp;
        }

        public IQueryable<Entertainers> Entertainers => EntContext.Entertainers;//.Include(x =>x.Ents);

        public void EditEnt(Entertainers ent)
        {
            EntContext.Update(ent);
            EntContext.SaveChanges();
        }

        public void EntAdd(Entertainers entertainer)
        {
            EntContext.Entertainers.Add(entertainer);
            EntContext.SaveChanges();
        }

        public void DeleteEnt(Entertainers entertainers)
        {
            EntContext.Entertainers.Remove(entertainers);
            EntContext.SaveChanges();
        }

    }
}
