using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
{

    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();


        public IdentifiableObject(string[] idents)

        {
            foreach (string ids in idents)
            {

                AddIdentifier(ids);
            }
        }
        public bool AreYou(string id)
        {
            return _identifiers.Contains(id.ToLower());
        }

        public string FirstId => _identifiers.Count != 0 ?
                                 _identifiers [0] : "";


        
        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}
