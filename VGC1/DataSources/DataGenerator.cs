using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGC1
{
    public static class DataGenerator
    {
        private static Random Random = new Random();

        public static Project GetProject()
        {
            Project newProject = new Project();
            return newProject;
        }
        public static Stage GetStage()
        {
            Stage newStage = new Stage(new Dimention(Random.Next(5,10), Random.Next(5,10)));
            newStage.AddModule(DataGenerator.GetModule());

            return newStage;
        }

        public static Module GetModule()
        {
            Module newModule = new Module(Random.Next(0, 100));
            return newModule;
        }

        public static Platform GetPlatform()
        {
            Platform newPlatform = new Platform();
            return newPlatform;
        }

        public static MoveEvent GetMoveEvent()
        {
            MoveEvent newMoveEvent = new MoveEvent(Random.Next(0, 500));
            return newMoveEvent;
        }
    }
}
