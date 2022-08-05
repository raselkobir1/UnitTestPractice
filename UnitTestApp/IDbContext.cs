using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApp
{
    public interface IDbContext
    {
        void AddItem(Course course);
        void Save();
    }
}
