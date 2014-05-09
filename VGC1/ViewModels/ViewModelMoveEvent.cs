using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGC1
{
    public class ViewModelMoveEvent: ViewModelBase
    {
        private MoveEvent moveEvent;

        public ViewModelMoveEvent()
        {
            this.moveEvent = new MoveEvent();
        }

        public ViewModelMoveEvent(MoveEvent move)
        {
            this.moveEvent = move;
        }

        public double BeginTime
        {
            get
            {
                return this.moveEvent.BeginTime;
            }
            set
            {
                if (value >= 0)
                {
                    this.moveEvent.BeginTime = value;
                    OnPropertyChanged("BeginTime");
                }
            }
        }
        public double Duration
        {
            get
            {
                return this.moveEvent.Duration;
            }
            set
            {
                if (value>0)
                {
                    this.moveEvent.Duration = value;
                    OnPropertyChanged("Duration");
                }
            }
        }
        public double BeginPosition
        {
            get
            {
                return this.moveEvent.BeginPosition;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.moveEvent.BeginPosition = value;
                    OnPropertyChanged("BeginPosition");
                }
            }
        }
        public double EndPosition
        {
            get
            {
                return this.moveEvent.EndPosition;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.moveEvent.EndPosition = value;
                    OnPropertyChanged("EndPosition");
                }
            }
        }


    }
}
