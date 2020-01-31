using GamesAPiClient.Model;
using ModelV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelV2
{
    public class LoginRepository
    {
        public static APIUsersEntities dataContext = new APIUsersEntities();
        public static List<user> GetAllUsers()
        {
            List<user> lu = dataContext.users.ToList();
            return lu;
        }

        public static user GetUsuari(string username)
        {
            user u;

            try
            {
                u = dataContext.users.Where(x => x.username == username).SingleOrDefault();
            }
            catch (Exception ex) {
                u = null;
            }

            return u;
        }

        public static user InsertUser(user u)
        {
            try
            {
                dataContext.users.Add(u);
                dataContext.SaveChanges();
                return GetUsuari(u.username);
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }

}
