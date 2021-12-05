using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ui.Models
{
    public class TodoManager : ITodoService
    {
        ITodoDal _todoDal;

        public TodoManager(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }

        public todo GetByID(int id)
        {
            return _todoDal.GetByID(id);
        }

        public List<todo> GetList()
        {
            return _todoDal.GetListAll();
        }

        public void TAdd(todo t)
        {
            _todoDal.Insert(t);
        }

        public void TDelete(todo t)
        {
            _todoDal.Delete(t);
        }

        public void TUpdate(todo t)
        {
            _todoDal.Update(t);
        }
    }
}
