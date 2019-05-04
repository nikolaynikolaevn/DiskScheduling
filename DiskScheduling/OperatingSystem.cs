using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class OperatingSystem : AbstractOperatingSystem
    {
        public OperatingSystem(IHardDriveReadable algorithm)
        {
            processes = new List<Process>();
            this.algorithm = algorithm;
        }
    }
}
