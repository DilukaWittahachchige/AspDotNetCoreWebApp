#region Directives
using EF;
using EF.Models;
using IDataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
#endregion

namespace DataAccess
{
    public class ClassRepository : GenericRepository<Class> , IClassRepository
    {
      
        public ClassRepository(MarkProcessingContext context)
            :base(context)
        {

        }
        
        //TODO Need to implement future
        public async Task<IEnumerable<Class>> LoadAllActive()
        {
            throw new NotImplementedException();
        }

    }
}
