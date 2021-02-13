﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EFCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
            
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
            
        }

        public void Update(Car entity)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var UpdateEntity = context.Entry(entity);
                UpdateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
