using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
{

    public class GameObject : IdentifiableObject
    {
        private string _description;
        private string _name;

        public GameObject(string[] ids, string name, string desc) : base(ids)
        {
            _name = name;
            _description = desc;
        }

        public string Name
        {
            get { return _name;}
        }

        public virtual string FullDesciption
        {
            get { return _description;}
        }

        public virtual string ShortDescription => $"{_name} (FirstId)";


    }
}
