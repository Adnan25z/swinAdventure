using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Iteration1
{
    public abstract class GameObject : Identifiable
    {
        private string _name;
        private string _desc;

        public GameObject(string[] idents, string name, string desc): base(idents)
        {
            _name = name;
            _desc = desc;
        }
    
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string ShortDesc
        {
            get
            {
                return ("A " + _name + " " + "("+this.FirstId+")");
            }
        }

        public virtual string FullDescription
        {
            get
            {
                return _desc;
            }
            set
            {
                _desc = value;
            }
        }
	}
}
