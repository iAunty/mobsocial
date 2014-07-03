using System.Collections;
using System.Collections.Generic;
using Nop.Core.Domain.Catalog;
using Nop.Plugin.Widgets.MobSocial.Domain;
using Nop.Plugin.Widgets.MobSocial.Controllers;

namespace Nop.Plugin.Widgets.MobSocial.Core
{
    /// <summary>
    /// Product service
    /// </summary>
    public interface IGenericService<T>
    {

        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);

        T GetById(int id);
        List<T> GetAll(string term, int count);


    }

}
