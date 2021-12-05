using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ui.Models
{
    public class EfTodoDal :GenericRepository<todo>, ITodoDal
    {
    }
}
