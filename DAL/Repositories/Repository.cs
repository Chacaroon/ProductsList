﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Abstractions;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
	public abstract class Repository<T> : IRepository<T> where T : Entity
	{
		protected Repository(ApplicationContext dbContext)
		{
			DbContext = dbContext;
		}

		protected DbContext DbContext { get; }

		public virtual T FindById(long id)
		{
			return GetAll(item => item.Id == id).SingleOrDefault();
		}

		public virtual IQueryable<T> GetAll()
		{
			return DbContext.Set<T>();
		}
		public virtual IQueryable<T> GetAll(Func<T, bool> predicate)
		{
			return GetAll().Where(predicate).AsQueryable();
		}

		public virtual void Add(T item)
		{
			DbContext.Set<T>().Add(item);
			DbContext.SaveChanges();
		}

		public virtual void AddRange(IEnumerable<T> item)
		{
			DbContext.Set<T>().AddRange(item);
			DbContext.SaveChanges();
		}

		public virtual void Update(T item)
		{
			DbContext.Entry(item).State = EntityState.Modified;
			DbContext.SaveChanges();
		}

		public virtual void Delete(T item)
		{
			DbContext.Set<T>().Remove(item);
			DbContext.SaveChanges();
		}

		public void DeleteById(long id)
		{
			T item = DbContext.Set<T>().SingleOrDefault(i => i.Id == id);
			DbContext.Set<T>().Remove(item);
			DbContext.SaveChanges();
		}

		public virtual void DeleteRange(IEnumerable<T> items)
		{
			DbContext.Set<T>().RemoveRange(items);
			DbContext.SaveChanges();
		}
	}
}
