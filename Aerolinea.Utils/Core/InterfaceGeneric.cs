using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharedkernel.Core
{
    public interface InterfaceGeneric<T, in TId> where T : class
    {

        Task FindByIdAsync(TId id);

        Task CreateAsync(T obj);

    

    }
}
