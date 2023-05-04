using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public interface IEntertainersRepository
    {
        IQueryable<Entertainers> Entertainers { get; }

        void EditEnt(Entertainers ent);
        void EntAdd(Entertainers ent);
        void DeleteEnt(Entertainers ent);
    }
}
