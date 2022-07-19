using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Iteration1;

namespace Iteration1
{
    public class Identifiable
    {
        List<string> _identifiers = new List<string>();

        public Identifiable(string[] idents)
        {
            _identifiers.AddRange(idents);
        }

        public bool AreYou(string id)
        {
            foreach(string Check in _identifiers)
            {
                if (id.ToLower() == Check)
                {
                    return true;
                }
            }
            return false;
        }

        public string FirstId
        {
            get
            {
                if (_identifiers.Count == 0)
                {
                    return "";
                }
                else
                {
                    return _identifiers.First();
                }
            }
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}
