using System;
using System.Collections.Generic;
using System.Text;
using GVNET;

namespace SampleProject
{
	class SampleNode : INode
	{
		private string _Name;
		private List<SampleEdge> _MyEdges = new List<SampleEdge>();

		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		public List<SampleEdge> MyEdges
		{
			get { return _MyEdges; }
		}

		public SampleNode(string name)
		{
			_Name = name;
		}

		public void AddEdge(SampleEdge edgeToAdd)
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
