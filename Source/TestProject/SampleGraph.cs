using System;
using System.Collections.Generic;
using System.Text;
using GVNET;

namespace SampleProject
{
	class SampleGraph : IGraph
	{
		private string _Name;
		private List<SampleNode> _MyNodes = new List<SampleNode>();
		private List<SampleEdge> _MyEdges = new List<SampleEdge>();

		public string Name
		{
			get { return _Name; }
		}

		public List<SampleNode> MyNodes
		{
			get { return _MyNodes; }
		}

		public List<SampleEdge> MyEdges
		{
			get { return _MyEdges; }
		}

		public SampleGraph(string name)
		{
			_Name = name;
		}

		public void AddNode(SampleNode nodeToAdd)
		{
			_MyNodes.Add(nodeToAdd);
		}

		public void AddEdge(SampleEdge edgeToAdd)
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
