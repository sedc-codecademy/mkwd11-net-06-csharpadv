using SEDC.Class15.ITCompnay.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class15.ITCompany.DataAccess.Interface
{
    public interface IDataBase<T> where T : BaseEntity
    {
        List<T> Reader();
        void Writer(List<T> dbEntities);
        //CRUD
        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
