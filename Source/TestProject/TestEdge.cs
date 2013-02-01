using System;
using System.Collections.Generic;
using System.Text;
using GVNET;

namespace TestProject
{
	class TestEdge : IEdge
	{
		private string _Name;
		private TestNode _Source;
		private TestNode _Drain;

		public string Name
		{
			get { return _Name; }
		}

		public TestNode Source
		{
			get { return _Source; }
		}

		public TestNode Drain
		{
			get { return _Drain; }
		}

		public TestEdge(string name, TestNode source, TestNode drain)
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
