using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface ICategoryService : IAbstractService<Category>
    {
       //add if other methods are needed apartfrom the crud
       //or overwrite below with new
        //Task <IEnumerable<Category>> Get();
    }
}
