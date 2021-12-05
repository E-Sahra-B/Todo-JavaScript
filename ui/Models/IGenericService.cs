using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ui.Models
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> GetList();
        T GetByID(int id);
    }
}
