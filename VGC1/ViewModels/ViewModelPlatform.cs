using System.Collections.ObjectModel;


namespace VGC1
{
    public class ViewModelPlatform : ViewModelBase
    {
        private Platform platform;
        public ObservableCollection<ViewModelMoveEvent> PlatformMoves { get; set; }
        public ViewModelPlatform()
        {
            this.platform = new Platform();
            this.PlatformMoves = new ObservableCollection<ViewModelMoveEvent>();
            this.platform.Moves.ForEach(delegate(MoveEvent move)
                {
                    this.PlatformMoves.Add(new ViewModelMoveEvent(move));
                });
        }


    }
}
