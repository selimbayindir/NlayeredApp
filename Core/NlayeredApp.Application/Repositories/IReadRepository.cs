﻿using NlayeredApp.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Application.Repositories
{
    public interface IReadRepository<T>: IRepository<T> where T : BaseEntity //t t olsun :)
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> predicate );
        //T GetOneAsync(Expression<Func<T,bool>> predicate); 
        Task<T> GetOneAsync(Expression<Func<T,bool>> predicate); 
        //T GetById(String id);
        Task<T> GetByIdAsync(String id);
    }
}
