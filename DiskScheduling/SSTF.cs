using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class SSTF : IHardDriveReadable
    {
        public int ExecuteRead(ref List<Process> processes, int lastReadSector)
        {
            List<Request> requests = new List<Request>();
            int min = 0;
            int difference = 0;
            Request lastRequest = null;
            foreach (Process p in processes)
            {
                requests.AddRange(p.Requests);
            }
            if (requests != null)
            {
                foreach (Request r in requests)
                {
                    difference = Math.Abs(lastReadSector - r.Sector);
                    if (difference < min || min == 0)
                    {
                        min = difference;
                        lastRequest = r;
                    }
                }
                processes.Single(x => x.ID == lastRequest.ProcessID).RemoveRequest(lastRequest.ID);
                return lastRequest.ID;
            }
            return -1;
        }
    }
}
