using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGC1
{
    class Module
    {
        private int id;
        private Platform platformA;
        private Platform platformB;
        
        //private PLCStateModule state;

        public Module(int id)
        {
            this.id = id;
            this.platformA = new Platform();
            this.platformB = new Platform();
        }

        public int ID
        {
            get { return this.id;}
            set
            {
                this.id = value;
            }
        }

        public Platform PlatformA
        {
            get { return this.platformA; }
            set
            {
                this.platformA = value;
            }
        }
        public Platform PlatformB
        {
            get { return this.platformB; }
            set
            {
                this.platformB = value;
            }
        }


    }
}
