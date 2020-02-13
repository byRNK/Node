using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Mvvm;

namespace NodeGame.View
{
    public class Node : BindableBase
    {
        private Node _mainNode;

        public Node MainNode
        {
            get
            {
                return _mainNode;
            }
            set
            {
                if (_mainNode == value)
                {
                    return;
                }

                _mainNode = value;
                OnPropertyChanged();
            }
        }

        private List<Node> _selectableNodes;

        public List<Node> SelectableNodes
        {
            get
            {
                return _selectableNodes;
            }
            set
            {
                if (value == _selectableNodes)
                {
                    return;
                }
                _selectableNodes = value;
                OnPropertyChanged();
            }
        }

        public Node()
        {

        }
    }
}
