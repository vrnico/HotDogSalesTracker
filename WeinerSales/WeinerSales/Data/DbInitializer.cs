﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WeinerSales.Models;

namespace WeinerSales.Data
{
    public class DbInitializer
    {
        public static void Initialize(WeinerDbContext context)
        {
            if (context.Roles.Any())
            {
                return;
            }


            var roles = new IdentityRole[]
            {
                new IdentityRole() { Name = "Manager" },
                new IdentityRole() { Name = "Sales Associate" }

            };



            foreach (var r in roles)
            {
                context.Roles.Add(r);
            }





            context.SaveChanges();
        }
    }
}