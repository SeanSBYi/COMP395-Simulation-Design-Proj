using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyERPrototype.MyCode.Manager
{
    class Spawner
    {
        List<MyCake> mySuffererList = new List<MyCake>();

        List<MyCake> myCurerLv1List = new List<MyCake>();

        List<MyCake> myCurerLv2List = new List<MyCake>();

        public Spawner()
        {
        }

        public void SpawnSufferer()
        {
            MySufferer newSufferer = new MySufferer();
            newSufferer._setPosition(10, 20);

            mySuffererList.Add(newSufferer);
        }

        public int NowSufferer() { return mySuffererList.Count; }

        public List<MyCake> GetSuffererData() { return mySuffererList; }

        public void Action()
        {

        }
    }
}
