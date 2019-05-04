using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class SCAN : IHardDriveReadable
    {
        public int ExecuteRead(ref List<Process> processes, int lastReadSector)
        {
            throw new NotImplementedException();
        }
    }
}
