using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class FCFS : IHardDriveReadable
    {
        public int ExecuteRead(ref List<Process> processes, int lastReadSector)
        {
            List<Request> requests = new List<Request>();
            foreach (Process p in processes)
            {
                requests.AddRange(p.Requests);
            }
            if (requests != null)
            {
                requests.OrderBy(x => x.ID);
                int sID = processes.Single(x => x.ID == requests[0].ProcessID).RemoveFirstRequest();
                return sID;
            }
            return -1;
        }
    }
}
