using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Mvvm;

namespace NodeGame.Node
{
    public class Node
    {
        private int _id;
        private string _mainText;
        private string _chacoiseText;
        private bool _isRoot;

        public bool IsRoot
        {
            get
            {
                return _isRoot;
            }
            set
            {
                if (value == _isRoot)
                {
                    return;
                }
                _isRoot = value;
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ChoiseText
        {
            get
            {
                return _chacoiseText;
            }
            set
            {
                if (value == _chacoiseText)
                {
                    return;
                }
                _chacoiseText = value;

            }
        }

        public string MainText
        {
            get { return _mainText; }
            set { _mainText = value; }
        }

        public List<int> ChoiseIds { get; set; }

        public Node()
        {
            ChoiseIds = new List<int>();
        }

        public void DummySet()
        {
            _id = 1;
            _mainText = "Merhaba";
            _chacoiseText = "BeniSeç";
            ChoiseIds.AddRange(new List<int>() { 3, 2, 3 });
        }

        public override bool Equals(object obj)
        {
            if (obj is Node node)
            {
                if (node.Id == Id &&
                    node.MainText == MainText &&
                    node.ChoiseText == ChoiseText &&
                    node.ChoiseIds.SequenceEqual(ChoiseIds))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
