
namespace IdentifiableObjectIteration
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

        public string FirstId
        {

            get
            {
                string identifier = "";
                if (_identifiers.Count != 0)
                {
                    identifier = _identifiers[0];
                }
                return identifier;
            }

        }
        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}








































