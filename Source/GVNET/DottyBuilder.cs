using System.Reflection;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;

namespace GVNET
{
	internal static class DottyBuilder
	{
		private static Dictionary<INode, int> nodeIDs = new Dictionary<INode, int>();
		private static int idCounter = 0;

		internal static DOTFile BuildDirectedGraph(IGraph graph)
		{
			ResetBuilder();

			DOTFile rv = new DOTFile();

			string graphType = graph.Directed ? "digraph" : "graph";

			rv.AppendLine(graphType + " MainGraph {");
			rv.PushIndent();

			WriteGraphAttributes(graph, rv);

			foreach (INode node in graph.Nodes)
			{
				nodeIDs.Add(node, ++idCounter);
				WriteNode(node, rv);
			}

			foreach (IEdge edge in graph.Edges)
			{
				WriteEdge(edge, rv, graph.Directed);
			}

			rv.PopIndent();
			rv.AppendLine("}");

			return rv;
		}

		private static void ResetBuilder()
		{
			nodeIDs = new Dictionary<INode, int>();
			idCounter = 0;
		}

		private static void WriteGraphAttributes(IGraph graph, DOTFile file)
		{
			List<Type> intTypes = new List<Type>();
			intTypes.AddRange(graph.GetType().GetInterfaces());

			Dictionary<string, string> attribs = new Dictionary<string, string>();

			foreach (Type interfaceType in intTypes)
			{
				if (!typeof(IFontScheme).IsAssignableFrom(interfaceType) && !typeof(IGraph).IsAssignableFrom(interfaceType))
					continue;

				PropertyInfo[] props = interfaceType.GetProperties();

				for (int i = 0; i < props.Length; i++)
				{
					PropertyInfo prop = props[i];
					DOTKeywordAttribute[] atts = (DOTKeywordAttribute[])prop.GetCustomAttributes(typeof(DOTKeywordAttribute), true);

					if (atts.Length != 1)
						continue;

					string value = PropConverter.GetPropValue(prop, graph);

					if (string.IsNullOrEmpty(value))
						continue;

					if (attribs.ContainsKey(atts[0].Keyword))
						attribs[atts[0].Keyword] += "," + Sanitize(value);
					else
						attribs.Add(atts[0].Keyword, Sanitize(value));
				}
			}

			foreach (string key in attribs.Keys)
			{
				file.AppendLine(key + "=\"" + attribs[key] + "\";");
			}
		}

		private static void WriteNode(INode node, DOTFile file)
		{
			file.Append("node" + nodeIDs[node].ToString());

			WriteAttributes(node, file);

			file.AppendLine(";");
		}

		private static void WriteEdge(IEdge edge, DOTFile file, bool directed)
		{
			file.Append("node" + nodeIDs[edge.HeadNode].ToString());

			if (directed)
				file.Append(" -> ");
			else
				file.Append(" -- ");

			file.Append("node" + nodeIDs[edge.TailNode].ToString());

			WriteAttributes(edge, file);

			file.AppendLine(";");
		}

		private static void WriteAttributes(object target, DOTFile file)
		{
			file.Append(" [");

			List<Type> intTypes = new List<Type>();
			intTypes.AddRange(target.GetType().GetInterfaces());

			Dictionary<string, string> attribs = new Dictionary<string, string>();

			foreach (Type interfaceType in intTypes)
			{
				if (!typeof(IEdge).IsAssignableFrom(interfaceType) && !typeof(INode).IsAssignableFrom(interfaceType) &&
					!typeof(IFontScheme).IsAssignableFrom(interfaceType))
					continue;

				PropertyInfo[] props = interfaceType.GetProperties();				

				for (int i = 0; i < props.Length; i++)
				{
					PropertyInfo prop = props[i];
					DOTKeywordAttribute[] atts = (DOTKeywordAttribute[])prop.GetCustomAttributes(typeof(DOTKeywordAttribute), true);

					if (atts.Length != 1)
						continue;

					string value = PropConverter.GetPropValue(prop, target);

					if (string.IsNullOrEmpty(value))
						continue;

					if (attribs.ContainsKey(atts[0].Keyword))
						attribs[atts[0].Keyword] += "," + Sanitize(value);
					else
						attribs.Add(atts[0].Keyword, Sanitize(value));
				}
			}

			bool wroteAttribute = false;

			foreach (string key in attribs.Keys)
			{
				file.Append(key + "=\"" + attribs[key] + "\" ");
				wroteAttribute = true;
			}

			//Remove extra space
			if (wroteAttribute)
			{
				file.Remove(file.Length - 1, 1);
				file.Append("]");
			}
			else	//Remove space and opening square bracket
				file.Remove(file.Length - 2, 2);
		}

		private static string Sanitize(string value)
		{
			return System.Web.HttpUtility.HtmlEncode(value);
		}
	}
}
