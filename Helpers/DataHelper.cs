﻿using ContactPro.Data;
using Microsoft.EntityFrameworkCore;

namespace ContactPro.Helpers
{
    public static class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider svcProvider)
        {
            //Get and instance of the db application context
            var dbContextSvc = svcProvider.GetRequiredService<ApplicationDbContext>();
            //Migration: Equivalent to update-database
            await dbContextSvc.Database.MigrateAsync();

        }
    }
}
