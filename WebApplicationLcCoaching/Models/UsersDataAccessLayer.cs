using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationLcCoaching.Models
{
    public class UsersDataAccessLayer
    {
        Lc_coatchingContext db = new Lc_coatchingContext();

        public IEnumerable<Users> GetAllUsers()
        {
            try
            {
                return db.Users.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new employee record    
        public int AddUser(Users user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee   
        public int UpdateUser(Users user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee   
        public Users GetUserData(int id)
        {
            try
            {
                Users users = db.Users.Find(id);
                return users;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular employee   
        public int DeleteUser(int id)
        {
            try
            {
                Users emp = db.Users.Find(id);
                db.Users.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        ////To Get the list of Cities   
        //public List<TblCities> GetCities()
        //{
        //    List<TblCities> lstCity = new List<TblCities>();
        //    lstCity = (from CityList in db.TblCities select CityList).ToList();

        //    return lstCity;
        //}

    }
}
