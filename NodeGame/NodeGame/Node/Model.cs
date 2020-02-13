using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGame.Node
{
    public class Model
    {
        public List<Node> NodeList
        {
            get;
            private set;
        }

        public Model(List<Node> list)
        {
            if (list == null)
            {
                throw new NotImplementedException();
            }
            NodeList = list;

            var firstNode = NodeList.FirstOrDefault(x => x.IsRoot);
            NodeList.Remove(firstNode);
            NodeList.Insert(0, firstNode);
        }
    }
}
