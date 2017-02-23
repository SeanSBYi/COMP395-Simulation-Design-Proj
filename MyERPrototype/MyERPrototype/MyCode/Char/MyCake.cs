using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyERPrototype.MyCode
{
    public class MyCake
    {
        float posX;
        float posY;
        float posZ;

        int iLife;
        double dCakeStress;

        long lBornTime;

        public MyCake()
        {
            posX = .0f;
            posY = .0f;
            posZ = .0f;

            iLife = 100;
            dCakeStress = .0d;

            lBornTime = Environment.TickCount;
        }

        public void _setPosition(float _x, float _y, float _z = 0)
        {
            this.posX = _x;
            this.posY = _y;
            this.posZ = _z;
        }

        public float getPositionX() { return posX; }
        public float getPositionY() { return posY; }
        public float getPositionZ() { return posZ; }

        public int _cakeLife
        {
            get { return iLife; }
            set { iLife = value; }
        }
        public double _cakeStress
        {
            get { return dCakeStress; }
            set { dCakeStress = value; }
        }
    }
}
