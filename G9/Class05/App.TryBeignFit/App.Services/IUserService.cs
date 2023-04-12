using App.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public interface IUserService<T> where T : BaseEntity
    {
        T Register(T user);
        T Login(T user);
        T StandardToPremium(T user);
    }
}
