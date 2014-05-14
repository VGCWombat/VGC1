using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGC1
{
    public class Project
    {
        public Stage Stage { get; set; }
        public Project()
        {
            this.Stage = DataGenerator.GetStage();
        }
    }
}
