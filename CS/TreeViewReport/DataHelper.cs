using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TreeViewReport {
    public class DataHelper {
        int level;
        int nodesCount;
        List<ParentNode> nodesList;
        List<DataRow> rows;
        DataTable dataTable;

        public DataTable ReportDataSource { 
            get {
                return dataTable;
            }
        }

        public int Level { get; set; }

        public List<ParentNode> NodesList { 
            get { 
                return nodesList; 
            } 
        }

        public DataHelper(int level) {
            Level = level;
            GenerateDataTable();
            nodesList = new List<ParentNode>();
            rows = dataTable.AsEnumerable().ToList();
            nodesCount = dataTable.Rows.Count - 1;
            ParseTree(null);
        }

        void GenerateDataTable() {
            dataTable = new DataTable();
            dataTable.Columns.Add("Key", typeof(object));
            dataTable.Columns.Add("ParentKey", typeof(object));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));
            dataTable.Rows.Add(0, null, "RootNode", "RootNode");
            int parentKey = 0;
            int currentKey = 1;
            Random rnd = new Random();
            for(int levelCount = 1; levelCount <= Level; levelCount++) {
                int childCount = rnd.Next(1, 4);
                for(int j = 1; j <= childCount; j++) {
                    string name = String.Format("Child Node {0}", currentKey);
                    string description = String.Format("Child Node {0} Parent {1}", currentKey, parentKey);
                    dataTable.Rows.Add(currentKey, parentKey, name, description);
                    currentKey++;
                }
                parentKey++;
            }
        }

        ParentNode CreateNewNode(DataRow dataRow) {
            ParentNode node = new ParentNode();
            node.NodeKey = dataRow[0];
            node.ParentNodeKey = dataRow[1];
            node.NodeName = dataRow[2].ToString();
            node.NodeDescription = dataRow[3].ToString();
            node.Children = new List<ParentNode>();
            return node;
        }

        void ParseTree(ParentNode parent) {
            if(parent != null) { //create child nodes
                List<DataRow> foundRows = rows.FindAll(x => x.ItemArray[1].Equals(parent.NodeKey));
                foreach(DataRow row in foundRows) {
                    if(nodesCount >= 0) {
                        ParentNode node = CreateNewNode(row);
                        parent.Children.Add(node);
                        node.Level = ++level;
                        ParseTree(node);
                        nodesCount--;
                        level--;
                    }
                }
            } else { // create root ParentNode
                DataRow foundRow = rows.Find(x => x.ItemArray[1].Equals(DBNull.Value));
                ParentNode node = CreateNewNode(foundRow);
                node.Level = level;
                nodesList.Add(node);
                rows.Remove(foundRow);
                nodesCount--;
                ParseTree(node);
            }
        }
    }

    public class SimpleNode {
        public object NodeKey { get; set; }
        public object ParentNodeKey { get; set; }
        public string NodeName { get; set; }
        public string NodeDescription { get; set; }
    }

    public class ParentNode : SimpleNode {
        public List<ParentNode> Children { get; set;}
        public int Level { get; set; }
    }
}
