﻿using Timely.API.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Timely.API.Repositories
{
    public class SqlWorkSessionRepository : IWorkSessionRepository
    {
        private readonly TimelyContext context;

        public SqlWorkSessionRepository(TimelyContext context)
        {
            this.context = context;
        }
        public async Task<List<WorkSession>> GetWorkSessionsAsync()
        {
            return await context.WorkSession.ToListAsync();
        }
    }
}
