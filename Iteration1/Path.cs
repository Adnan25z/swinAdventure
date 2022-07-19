using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration1
{
    public class Path : GameObject
    {
        private Location _initial = null;
        private Location _final = null;

        public Path(string[] ids, string name, string desc, Location initial, Location final) : base(ids, name, desc)
        {
            _initial = initial;
            _final = final;
        }

        public Location Initial { get { return _initial; } set { _initial = value; } }
        public Location Final { get { return _final; } set { _final = value; } }

        public void MovePlayer(Player p)
        {
            p.Location= Final;
        }


        public override string FullDescription
        {
            get
            {
                return "You are heading in " + Name + ".\n i.e. " + base.FullDescription;
            }
        }
    }
}
