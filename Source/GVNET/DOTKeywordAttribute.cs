using System;

namespace GVNET
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
	internal class DOTKeywordAttribute : Attribute
	{
		private string _Keyword;

		public DOTKeywordAttribute(string keyword)
		{
			_Keyword = keyword;
		}

		public string Keyword
		{
			get { return _Keyword; }
		}
	}
}
