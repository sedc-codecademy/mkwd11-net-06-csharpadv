using App.Domain.Infrastructure;
using App.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.InitData
{
    public static class InitDataLoad
    {
        public static IDatabase<StandardUser> database = new Database<StandardUser>();
        public static IDatabase<PremiumUser> databasePremium = new Database<PremiumUser>();

        public static List<StandardUser> Add()
        {
            database.Insert(new StandardUser
            {
                FirstName = "Ljupcho",
                LastName = "Rechkoski",
                UserName = "test123",
                Password = "test123"
            });
            database.Insert(new StandardUser
            {
                FirstName = "Nikola",
                LastName = "Nikoloski",
                UserName = "test222",
                Password = "test222"
            });
            database.Insert(new StandardUser
            {
                FirstName = "Simona",
                LastName = "Simonoska",
                UserName = "test223",
                Password = "test223"
            });

            return database.GetAll();
        }

        public static List<PremiumUser> AddPremium()
        {
            databasePremium.Insert(new PremiumUser
            {
                FirstName = "Ljupcho",
                LastName = "Rechkoski",
                UserName = "test123",
                Password = "test123"
            });
            databasePremium.Insert(new PremiumUser
            {
                FirstName = "Nikola",
                LastName = "Nikoloski",
                UserName = "test222",
                Password = "test222"
            });
            databasePremium.Insert(new PremiumUser
            {
                FirstName = "Simona",
                LastName = "Simonoska",
                UserName = "test223",
                Password = "test223"
            });

            return databasePremium.GetAll();
        }
    }
}
