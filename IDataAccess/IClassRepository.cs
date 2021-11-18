
#region Directives
using EF.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
#endregion

namespace IDataAccess
{
    public interface IClassRepository : IGenericRepository<Class>
    {
        Task<IEnumerable<Class>> LoadAllActive();
    }
}
