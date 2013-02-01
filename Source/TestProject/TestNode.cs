using System;
using System.Collections.Generic;
using System.Text;
using GVNET;

namespace TestProject
{
	class TestNode : INode
	{
		private string _Name;
		private List<TestEdge> _MyEdges = new List<TestEdge>();

		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		public List<TestEdge> MyEdges
		{
			get { return _MyEdges; }
		}

		public TestNode(string name)
		{
			_Name = name;
		}

		public void AddEdge(TestEdge edgeToAdd)
		{
			_MyEdges.Add(edgeToAdd);
		}

		public override string ToString()
		{
			return Name;
		}

		#region INode Members

		public string Label
		{
			get { return Name; }
		}

		public IEdge[] Edges
		{
			get { return MyEdges.ToArray(); }
		}

		#endregion
	}
}
