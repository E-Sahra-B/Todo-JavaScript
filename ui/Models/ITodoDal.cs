using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ui.Models
{
    public interface ITodoDal
    {
        void Insert(todo t);
        void Delete(todo t);
        void Update(todo t);
        List<todo> GetListAll();
        todo GetByID(int id);
        List<todo> GetListAll(Expression<Func<todo, bool>> filter);
    }
}
