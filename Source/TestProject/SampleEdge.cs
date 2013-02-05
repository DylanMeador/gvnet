using System;
using System.Collections.Generic;
using System.Text;
using GVNET;

namespace SampleProject
{
	class SampleEdge : IEdge
	{
		private string _Name;
		private SampleNode _Source;
		private SampleNode _Drain;

		public string Name
		{
			get { return _Name; }
		}

		public SampleNode Source
		{
			get { return _Source; }
		}

		public SampleNode Drain
		{
			get { return _Drain; }
		}

		public SampleEdge(string name, SampleNode source, SampleNode drain)
		{
			_Name = name;
			_Source = source;
			_Drain = drain;
		}
		
		#region IEdge Members

		public string Label
		{
			get { return Name; }
		}

		public INode HeadNode
		{
			get { return Source; }
		}

		public INode TailNode
		{
			get { return Drain; }
		}

		#endregion
	}
}
