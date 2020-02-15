using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Mvvm;

namespace NodeGame.View
{
    public class NodeViewModel : BindableBase
    {
        private NodeGame.Node.Node _mainNode;
        private List<NodeGame.Node.Node> _selectableNodes;

        public NodeGame.Node.Node MainNode
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

        public List<NodeGame.Node.Node> SelectableNodes
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

        private Node.Model _model;

        public NodeViewModel(Node.Model model)
        {
            SelectableNodes = new List<Node.Node>();

            _model = model ?? throw new NotImplementedException(nameof(model));

            MainNode = _model.NodeList.First() ?? throw new NotImplementedException(nameof(MainNode));

            var ids = _model.NodeList.SelectMany(x => x.ChoiseIds);

            ids.ToList().ForEach(x => SelectableNodes.Add(_model.NodeList[x]));

        }
    }
}
