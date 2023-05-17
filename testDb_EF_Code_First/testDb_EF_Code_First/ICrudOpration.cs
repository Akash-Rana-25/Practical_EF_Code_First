using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDb_EF_Code_First
{
    internal interface ICrudOpration
    {
        void Add(Employee employee);
        void Update(int Id);
        void Delete(int Id);
        void Read();
    }
}
