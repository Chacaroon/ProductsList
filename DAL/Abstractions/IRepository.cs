using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Entities;

namespace DAL.Abstractions
{
	public interface IRepository<T> where T : Entity
	{
		IQueryable<T> GetAll();
		IQueryable<T> GetAll(Func<T, bool> predicate);
		T FindById(long id);
		void Add(T item);
		void AddRange(IEnumerable<T> item);
		void Update(T item);
		void Delete(T item);
		void DeleteById(long id);
		void DeleteRange(IEnumerable<T> item);
	}

}
