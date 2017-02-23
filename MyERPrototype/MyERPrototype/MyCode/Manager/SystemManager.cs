using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyERPrototype.MyCode.Manager
{

    public class SystemManager
    {
        Spawner spawner;

        int iRoom1X;
        int iRoom1Y;
        int iRoom1W;
        int iRoom1H;

        int iRoom2X;
        int iRoom2Y;
        int iRoom2W;
        int iRoom2H;

        int iRoom3X;
        int iRoom3Y;
        int iRoom3W;
        int iRoom3H;

        int iTotalSufferer;
        int iNowSufferer;
        
        int iTotalCurerLv1;
        int iNowCurerLv1;
        
        int iTotalCurerLv2;
        int iNowCurerLv2;

        public SystemManager ()
        {
            spawner = new Spawner();

            this.iTotalSufferer = 10;
            this.iNowSufferer = 0;

            this.iTotalCurerLv1 = 0;
            this.iNowCurerLv1 = 0;

            this.iTotalCurerLv2 = 0;
            this.iNowCurerLv2 = 0;

            iRoom1X = 0;
            iRoom1Y = 0;
            iRoom1W = 0;
            iRoom1H = 0;

            iRoom2X = 0;
            iRoom2Y = 0;
            iRoom2W = 0;
            iRoom2H = 0;

            iRoom2X = 0;
            iRoom2Y = 0;
            iRoom2W = 0;
            iRoom2H = 0;
        }

        public void SpawnSufferer()
        {
            if (iTotalSufferer > iNowSufferer)
            {
                spawner.SpawnSufferer();
                iNowSufferer = spawner.NowSufferer();
            }
        }

        public int _nowSuffererCnt
        {
            get { return iNowSufferer; }
            set { iNowSufferer = value; }
        }

        public int _Room1X { get { return iRoom1X; } set { iRoom1X = value; } }
        public int _Room1Y { get { return iRoom1Y; } set { iRoom1Y = value; } }
        public int _Room1W { get { return iRoom1W; } set { iRoom1W = value; } }
        public int _Room1H { get { return iRoom1H; } set { iRoom1H = value; } }

        public bool isSufferer() { return iNowSufferer != 0;  }
        public List<MyCake> GetSuffererData() { return spawner.GetSuffererData(); }
    }
}
