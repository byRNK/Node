using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGame.Node
{
    public class NodeManager
    {
        private Node _node;

        public NodeManager()
        {
            _node = new Node();

            _node.DummySet();

            var a = JsonConvert.SerializeObject(_node);
            var reeadedJsonValue = string.Empty;

            //using (var writer = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Node.txt"), true))
            //{
            //    writer.WriteLine(a);
            //    writer.Close();
            //}

            using (var reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Node.txt"), true))
            {
                reeadedJsonValue = reader.ReadToEnd();
                reader.Close();

            }

            var k = JsonConvert.DeserializeObject(reeadedJsonValue, typeof(Node));

            var boole = k.Equals(_node);

            Console.WriteLine(boole.ToString());

        }
    }
}
