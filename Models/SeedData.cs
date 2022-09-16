using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace AIDA_API.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UserContext(serviceProvider.GetRequiredService<DbContextOptions<UserContext>>()))
            {
                if (context == null) { return; }

                //List<User> users = new List<User>()
                //{
                //    new User(){ user_name = "Vladimir", user_email ="Chlapa@mail.ru", user_password ="126Thrir", user_isConfirmed =true, user_level = 4.25f }
                //};

                //context.User.AddRange(users);
                context.SaveChanges();
            }
        }
    }
}
