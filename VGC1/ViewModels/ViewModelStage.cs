using System.ComponentModel;
using System.Collections.ObjectModel;
namespace VGC1
{
    public class ViewModelStage: ViewModelBase
    {
        private Stage stage;
        public ObservableCollection<Module> Modules { get; set; }

        public ViewModelStage()
        {
            this.Modules= new ObservableCollection<Module>();
        }

    }
}
