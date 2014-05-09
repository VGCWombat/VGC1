using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGC1
{
    public class MoveEvent
    {
        private double beginTime;
        private double duration;
        private double beginPosition;
        private double endPosition;

        public static Random random = new Random();
        public MoveEvent()
        {
            this.beginTime = random.Next(0, 200);
            this.duration = random.Next(0, 50);
            this.beginPosition = random.Next(0, 20);
            this.endPosition = random.Next(40, 100);
        }
        public MoveEvent(int begin)
        {
            this.beginTime = random.Next(begin, begin+200);
            this.duration = random.Next(0, 50);
            this.beginPosition = random.Next(0, 20);
            this.endPosition = random.Next(40, 100);
        }
        public double BeginTime
        {
            get { return this.beginTime; }
            set
            {
                this.beginTime = value;
            }
        }
        public double Duration
        {
            get { return this.duration; }
            set
            {
                this.duration = value;
            }
        }
        public double BeginPosition
        {
            get { return this.beginPosition; }
            set
            {
                this.beginPosition = value;
            }
        }
        public double EndPosition
        {
            get { return this.endPosition; }
            set
            {
                this.endPosition = value;
            }
        }

    }
}