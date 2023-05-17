using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDb_EF_Code_First
{
    internal class EmployeeEntities: DbContext
    {
        public EmployeeEntities() : base("ConString")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EmployeeEntities>());
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
