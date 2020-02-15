using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NodeGame.Node
{
    internal class NodeManager
    {
        private List<Node> _nodes;
        public NodeManager()
        {
            _nodes = ReadFromFile();

            if (_nodes != null &&
                _nodes.Count != 0)
            {
                MessageBox.Show($"newlist sayısı: {_nodes.Count}");
            }

        }

        internal List<Node> ReadFromFile()
        {
            var reeadedJsonValue = string.Empty;

            using (var reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Node1.txt"), true))
            {
                reeadedJsonValue = reader.ReadToEnd();
                reader.Close();
            }

            var nodes = JsonConvert.DeserializeObject<List<Node>>(reeadedJsonValue);

            return nodes;
        }

        private bool CreateDummyFile()
        {
            try
            {
                var list = new List<Node>();
                list.Add(new Node());
                list.Add(new Node());
                list.Add(new Node());
                list.Add(new Node());
                list.Add(new Node());
                list.Add(new Node());
                list.Add(new Node());
                list.Add(new Node());
                list.Add(new Node());

                list.ForEach(x => x.DummySet());

                var willWriteString = JsonConvert.SerializeObject(list);

                using (var writer = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Node1.txt"), true))
                {
                    writer.WriteLine(willWriteString);
                    writer.Close();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Node> GetNodes()
        {
            return _nodes;
        }
    }
}
