using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ShelterApp.Data
{
	public class GenericRepository<T, C>
		where T: class, new()
        where C: DbContext, new()
    {
        public bool Insert(T entity)
        {
            try
            {
                using C context = new();
                EntityEntry result = context.Add(entity);
                
                context.SaveChanges();

                return result.State == EntityState.Added;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                using C context = new();
                EntityEntry result = context.Update(entity);

                context.SaveChanges();

                return result.State == EntityState.Modified;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(T entity)
        {
            try
            {
                using C context = new();
                EntityEntry result = context.Remove(entity);

                context.SaveChanges();

                return result.State == EntityState.Deleted;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T GetById(int id)
        {
            using C context = new();
            return context.Set<T>().Find(id) ?? throw new Exception("Id değeri ile veri bulunamadı");
        }

        public List<T> GetAll()
        {
            using C context = new();
            return context.Set<T>().ToList();
        }
    }
}

