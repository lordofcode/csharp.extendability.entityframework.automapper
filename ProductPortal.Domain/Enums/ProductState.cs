using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Domain.Enums
{
    public enum ProductState
    { 
        Import = 0,
        Draft = 1,
        Published = 2,
        Archived = 3,
        Deleted = 4
    }
}
