using Sana05.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05.Interfaces
{
    public interface IMaintainable
    {
        public void ScheduleMaintenance(DateTime date);
        public bool IsUnderMaintenance { get; }

        //public void GetFullInfoAboutMaintenance();
        //додав цей метод для того, щоб показувати в головному меню всю інформацію про обслуговування
    }
}
