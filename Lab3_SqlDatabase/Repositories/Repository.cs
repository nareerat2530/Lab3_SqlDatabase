
using Lab3_SqlDatabase.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SqlDatabase.Repositories
{
    public class Repository<Tentity> : IRepository<Tentity> where Tentity : class
    {
        protected readonly BookStores_Lab2_NareeratContext context;

        public Repository( BookStores_Lab2_NareeratContext context)
        {
            this.context = context;
        }
        public Tentity Get(int id)
        {
            return context.Set<Tentity>().Find(id);
        }

        public IEnumerable<Tentity> GetAll()
        {
            return context.Set<Tentity>().ToList();
        }

        public void Add(Tentity entity)
        {
            context.Set<Tentity>().Add(entity);
        }

        public void AddRange(IEnumerable<Tentity> entities)
        {
            context.Set<Tentity>().AddRange(entities);
        }

        public void Remove(Tentity entity)
        {
            context.Set<Tentity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<Tentity> entities)
        {
            context.Set<Tentity>().RemoveRange(entities);
        }

        
    }
}
