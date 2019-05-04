using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskScheduling
{
    public partial class MainForm : Form
    {
        private OperatingSystem os;
        private IHardDriveReadable algorithm;
        private static Random rnd;

        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
            rbtnFCFS_CheckedChanged(null, null);
        }

        private void rbtnFCFS_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = new FCFS();
            os = new OperatingSystem(algorithm);
            GenerateSampleRequests();
        }

        private void GenerateSampleRequests()
        {
            Process p1 = new Process();
            p1.AddRequest(89);
            p1.AddRequest(3);
            p1.AddRequest(74);
            p1.AddRequest(51);
            p1.AddRequest(18);
            p1.AddRequest(55);
            p1.AddRequest(44);
            p1.AddRequest(37);
            p1.AddRequest(0);
            p1.AddRequest(28);
            p1.AddRequest(48);
            p1.AddRequest(89);
            p1.AddRequest(41);
            p1.AddRequest(24);
            p1.AddRequest(93);

            os.AddProcess(p1);
        }

        private void GenerateRandomRequests()
        {
            Process p1 = new Process();
            p1.AddRequest(rnd.Next(1, 100));
            os.AddProcess(p1);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            timerRequests.Start();
            btnRun.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerRequests.Stop();
            btnStop.Enabled = false;
            btnRun.Enabled = true;
        }

        private void UpdateRequests()
        {
            lbSectors.Items.Clear();
            List<Process> processes = os.Processes;
            foreach (Process p in processes)
            {
                foreach (Request r in p.Requests)
                {
                    lbSectors.Items.Add(r.Sector);
                }
            }
        }

        private void timerRequests_Tick(object sender, EventArgs e)
        {
            GenerateRandomRequests();
            UpdateRequests();

            tbCurrent.Text = os.ReadHardDrive().ToString();
            trackBarSectors.Value = int.Parse(tbCurrent.Text);
        }

        private void rbtnSSTF_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = new SSTF();
            os = new OperatingSystem(algorithm);
            GenerateSampleRequests();
        }
    }
}
