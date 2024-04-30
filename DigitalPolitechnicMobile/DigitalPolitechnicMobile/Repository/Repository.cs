using DigitalPolitechnicMobile.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitalPolitechnicMobile.Repository
{
    internal class Repository
    {
        private readonly PolitechnicDBContext dbContext;

        public Repository(PolitechnicDBContext DBContext)
        {
            dbContext = DBContext;
        }


        public void AddUser(User user)
        {
            if (!dbContext.Users.Contains(user))
            {
                dbContext.Users.Add(user);
            }
            dbContext.SaveChanges();
        }
        public User CheckUser(User user)
        {
            return dbContext.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
        }
        public List<User> GetUsers()
        {
            return dbContext.Users.ToList();
        }


        public void AddMenu(Menu item)
        {
            if (!dbContext.Menu.Contains(item))
            {
                dbContext.Menu.Add(item);
            }
            dbContext.SaveChanges();
        }
        
        public List<Menu> GetMenu()
        {
            return dbContext.Menu.ToList();
        }

        // Add functions for added, checked, get data, (edit data what is needed)

    }
}
