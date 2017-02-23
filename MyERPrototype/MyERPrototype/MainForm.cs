using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyERPrototype.MyCode.Manager;
using MyERPrototype.MyCode;

namespace MyERPrototype
{
    public partial class Prototype : Form
    {
        public const int TimeMinValue = 5000;
        public const int TimeMaxValue = 10000;

        public const int CakeSize = 10;

        Boolean bLoop;

        System.Threading.Thread t;

        SystemManager systemManager;

        Random rand = new Random();
        Timer mytimer = new Timer();

        //public int TimeMinValue { get; private set; }

        int tX = 100;

        // For Drawer
        // Create pen.
        Pen blackPen = new Pen(Color.Black, 2);
        Pen yellowPen = new Pen(Color.Yellow, 2);
        Pen redPen = new Pen(Color.Red, 2);

        public Prototype()
        {
            InitializeComponent();

            bLoop = false;

            systemManager = new SystemManager();

            systemManager._Room1X = groupBoxWR.Location.X;
            systemManager._Room1Y = groupBoxWR.Location.Y;
            systemManager._Room1W = groupBoxWR.Width;
            systemManager._Room1H = groupBoxWR.Height;
        }

        private void Prototype_Load(object sender, EventArgs e)
        {
            //create and start a new thread in the load event.
            //passing it a method to be run on the new thread.
            t = new System.Threading.Thread(DoThisAllTheTime);
            t.IsBackground = false;
            t.Start();
        }

        public void DoThisAllTheTime()
        {
            while (true)
            {
                //you need to use Invoke because the new thread can't access the UI elements directly
                MethodInvoker mi = delegate () { this.Text = DateTime.Now.ToString(); };
                Invoke(mi);
            }
        }

        private void btnLooping_Click(object sender, EventArgs e)
        {
            //stop the thread.
            //if (bLoop == false)
            //    t.Suspend();
            //else
            //    t.Resume();

            mytimer.Tick += new EventHandler(TimerEventProcessor);
            int fortimerinterval = rand.Next(TimeMinValue, TimeMaxValue);
            mytimer.Interval = fortimerinterval;
            mytimer.Enabled = true;
            mytimer.Start();
        }

        public void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            int fortimerinterval = rand.Next(TimeMinValue, TimeMaxValue);
            mytimer.Interval = fortimerinterval;

            systemManager.SpawnSufferer();

            this.label1.Text = systemManager._nowSuffererCnt.ToString();

            //System.Diagnostics.Debug.WriteLine(DateTime.Now);
        }

        private void Prototype_FormClosing(object sender, FormClosingEventArgs e)
        {
            // terminate a Thread
            t.Abort();
        }

        private void Prototype_Paint(object sender, PaintEventArgs e)
        {
            if (systemManager.isSufferer() == true)
            {
                List<MyCake> myCake = systemManager.GetSuffererData();
                for (int i = 0; i < systemManager._nowSuffererCnt; i++)
                {
                    //e.Graphics.DrawRectangle(blackPen, myCake[i].getPositionX(), myCake[i].getPositionY(), CakeSize, CakeSize);
                    e.Graphics.DrawRectangle(blackPen, 150 ,
                                                150 + (i * 15),
                                                CakeSize, CakeSize);
                }
            }
        }

        private void timeMoving_Tick(object sender, EventArgs e)
        {
            tX += 1;
            Invalidate();
        }

        private void groupBoxWR_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
