using System.IO;
using System.Text;
using System.Diagnostics;
using System;

namespace GVNET
{
	internal class DOTFile
	{
		private StringBuilder stream = new StringBuilder();
		private string tabStack = string.Empty;

		bool tabAdded = false;

		public int Length
		{
			get { return stream.Length; }
		}

		internal void Append(string value)
		{
			if (tabAdded == false)
			{
				stream.Append(tabStack + value);
				tabAdded = true;
			}
			else
				stream.Append(value);
		}

		internal void AppendLine()
		{
			stream.AppendLine();
			tabAdded = false;
		}

		internal void AppendLine(string value)
		{
			if (tabAdded == false)
				stream.AppendLine(tabStack + value);
			else
				stream.AppendLine(value);

			tabAdded = false;
		}

		internal void Remove(int startIndex, int length)
		{
			stream.Remove(startIndex, length);
		}

		public override string ToString()
		{
			return stream.ToString();
		}

		internal bool Save(string directory, string fileName)
		{
			//Remove spaces
			fileName = fileName.Replace(" ", "_");

			directory = directory.TrimEnd('\\', '/') + "/";
			fileName = fileName + ".gv";

			string file = directory + fileName;

			using (var sw = new StreamWriter(file))
			{
				sw.Write(stream.ToString());
				sw.Close();
			}

			return true;
		}

		internal void PushIndent()
		{
			tabStack += "\t";
		}

		internal void PopIndent()
		{
			if (tabStack.Length > 2)
				tabStack = tabStack.Substring(2);
			else
				tabStack = "";
		}
	}
}
