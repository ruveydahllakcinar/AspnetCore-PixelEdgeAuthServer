﻿using Microsoft.EntityFrameworkCore;
using PixelEdgeAuthServer.CoreLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelEdgeAuthServer.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
