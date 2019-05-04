using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    abstract class AbstractOperatingSystem
    {
        protected List<Process> processes;
        protected IHardDriveReadable algorithm;
        protected int lastReadSector;

        public int ReadHardDrive()
        {
            lastReadSector = algorithm.ExecuteRead(ref processes, lastReadSector);
            return lastReadSector;
        }

        public void AddProcess(Process process)
        {
            if (!processes.Exists(x => x.ID == process.ID)) processes.Add(process);
        }

        public void RemoveProcess(int id)
        {
            processes.RemoveAll(x => x.ID == id);
        }

        public List<Process> Processes { get => processes; }
    }
}
