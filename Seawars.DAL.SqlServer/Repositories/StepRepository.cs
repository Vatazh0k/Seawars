﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seawars.DAL.Context;
using Seawars.Domain.Entities;
using Seawars.Interfaces.Repositories;

namespace Seawars.DAL.SqlServer.Repositories
{
    public class StepRepository : IRepository<Step>
    {
        private readonly DataBaseContext _context;
        public StepRepository(DataBaseContext context)
        {
            _context = context;
        }

        public List<Step> GetAll()
        {
            throw new NotImplementedException();
        }

        public Step GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add<T>(T Steps)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExistId(int id)
        {
            throw new NotImplementedException();
        }
    }
}