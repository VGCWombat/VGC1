using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGC1
{
    class Stage
    {
        private int id;
        private Dimention dimention;
        private List<Module> modules;

        public Stage(Dimention dimention)
        {
            this.dimention = dimention;
            this.modules = new List<Module>();
        }
        public int ID
        {
            get { return this.id; }
            set
            {
                this.id = value;
            }
        }
        public List<Module> Modules
        {
            get { return this.modules; }
            set
            {
                this.modules = value;
            }
        }

        public bool AddModule(Module newModule)
        {
            bool check = true;
            modules.ForEach(delegate(Module existingModule)
            {
                if (newModule.PlatformA.Location == existingModule.PlatformA.Location
                    || newModule.PlatformA.Location == existingModule.PlatformB.Location
                    || newModule.PlatformB.Location == existingModule.PlatformA.Location
                    || newModule.PlatformB.Location == existingModule.PlatformB.Location)
                    check = false;
            });
            if (check)
            {
                modules.Add(newModule);
                return true;
            }
            return false;
        }


    }
}
