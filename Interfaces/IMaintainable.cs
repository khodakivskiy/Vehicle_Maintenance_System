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
    }
}
