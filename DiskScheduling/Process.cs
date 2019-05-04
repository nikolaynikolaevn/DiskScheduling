using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class Process
    {
        private List<Request> requests;
        private static int counter = 0;
        private int id;

        public Process()
        {
            requests = new List<Request>();
            counter++;
            id = counter;
        }

        public List<Request> Requests { get => requests; }
        public int ID { get => id; }

        public void AddRequest(int sector)
        {
            Request r = new Request(sector, id);
            requests.Add(r);
        }

        public void RemoveRequest(int id)
        {
            requests.RemoveAll(x => x.ID == id);
        }

        public int RemoveFirstRequest()
        {
            if (requests.Count > 0)
            {
                int sID = requests[0].Sector;
                requests.RemoveAt(0);
                return sID;
            }
            return -1;
        }

        public Request GetFirstRequest()
        {
            if (requests.Count > 0) return requests[0];
            return null;
        }

        public Request GetLastRequest()
        {
            if (requests.Count > 0) return requests[requests.Count - 1];
            return null;
        }
    }
}
