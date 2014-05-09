using System.ComponentModel;
using System.Collections.ObjectModel;

namespace VGC1
{
    public class ViewModelModule: ViewModelBase
    {
        private Module module;
        public ObservableCollection<ViewModelPlatform> Platforms { get; set; }

        public ViewModelModule()
        {
            this.module = new Module(1);
            this.Platforms = new ObservableCollection<ViewModelPlatform>();
            this.Platforms.Add(new ViewModelPlatform());
            this.Platforms.Add(new ViewModelPlatform());
        }
    }
}
