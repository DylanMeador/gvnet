using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GVNET;

namespace TestProject
{
	class TestGraph : IGraph
	{
		private string _Name;
		private List<TestNode> _MyNodes = new List<TestNode>();
		private List<TestEdge> _MyEdges = new List<TestEdge>();

		public string Name
		{
			get { return _Name; }
		}

		public List<TestNode> MyNodes
		{
			get { return _MyNodes; }
		}

		public List<TestEdge> MyEdges
		{
			get { return _MyEdges; }
		}

		public TestGraph(string name)
		{
			_Name = name;
		}

		public void AddNode(TestNode nodeToAdd)
		{
			_MyNodes.Add(nodeToAdd);
		}

		public void AddEdge(TestEdge edgeToAdd)
		{
			_MyEdges.Add(edgeToAdd);
			edgeToAdd.Source.AddEdge(edgeToAdd);
		}


		#region IGraph Members

		public INode[] Nodes
		{
			get { return MyNodes.ToArray(); }
		}

		public IEdge[] Edges
		{
			get { return MyEdges.ToArray(); }
		}

		public string Label
		{
			get { return Name; }
		}

		public bool Directed
		{
			get { return false; }
		}

		#endregion
	}
}
