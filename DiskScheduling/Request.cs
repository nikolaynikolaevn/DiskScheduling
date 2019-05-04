using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class Request
    {
        private int sector;
        private static int counter = 0;
        private int id;
        private int processID;

        public Request(int sector, int processID)
        {
            this.sector = sector;
            counter++;
            id = counter;
            this.processID = processID;
        }

        public int Sector { get => sector; }

        public int ID { get => id; }

        public int ProcessID { get => processID; }
    }
}
