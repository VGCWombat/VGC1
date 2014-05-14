using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGC1
{
    public class Platform
    {
        private Dimention location;
        private List<MoveEvent> moves;
        private bool active;

        //private PLCStatePlatform state;

        public Platform()
        {
            this.location = new Dimention(1, 2);
            this.active = true;
            this.moves = new List<MoveEvent>();
            this.moves.Add(new MoveEvent(0));
            this.moves.Add(new MoveEvent(200));
            this.moves.Add(new MoveEvent(400));
        }
        public Dimention Location
        {
            get
            {
                return this.location;
            }
            set
            {
                location = value;
            }
        }

        public List<MoveEvent> Moves
        {
            get 
            { 
                return this.moves; 
            }
            set
            {
                this.moves = value;
            }
        }

        public bool Active
        {
            get
            {
                return this.active;
            }
            set
            {
                this.active = value;
            }
        }
    }
}
