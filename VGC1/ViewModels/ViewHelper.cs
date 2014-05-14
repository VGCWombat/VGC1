using System.ComponentModel;
using System.Collections.ObjectModel;
/*
namespace VGC1
{
    public class ViewHelper: ObservableCollection<ViewModelPlatform>
    {
        public ViewHelper(): base()
        {
            Add(new ViewModelPlatform());
            Add(new ViewModelPlatform());
            Add(new ViewModelPlatform());
            Add(new ViewModelPlatform());
            Add(new ViewModelPlatform());
        } 
    }
}
*/
namespace VGC1
{
    public class ViewHelper: ObservableCollection<ViewModelModule>
    {
        public ViewHelper(): base()
        {
            Add(new ViewModelModule());
            Add(new ViewModelModule());
            Add(new ViewModelModule());
            Add(new ViewModelModule());
            Add(new ViewModelModule());
        } 
    }
}

