using System.Collections.Generic;

namespace GVNET
{
	/// <summary>
	/// This class is responsible for saving the graphs.
	/// </summary>
	public static class GraphManager
	{
		/// <summary>
		/// Saves the graph at the specified directory with the graph label as the name.
		/// </summary>
		/// <param name="graph">The <see cref="IGraph">graph</see> that is being saved.</param>
		/// <param name="directory">The directory the file is saved in.</param>
		/// <returns>True if save was successful.</returns>
		public static bool SaveGraph(IGraph graph, string directory)
		{
			return SaveGraph(graph, directory, graph.Label);
		}

		/// <summary>
		/// Saves the graph at the specified directory with the specified name.
		/// </summary>
		/// <param name="graph">The <see cref="IGraph">graph</see> that is being saved.</param>
		/// <param name="directory">The directory the file is saved in.</param>
		/// <param name="fileName">The name of the file to be saved.</param>
		/// <returns>True if save was successful.</returns>
		public static bool SaveGraph(IGraph graph, string directory, string fileName)
		{
			DOTFile dotFile = DottyBuilder.BuildDirectedGraph(graph);
			return dotFile.Save(directory, fileName);
		}

		/// <summary>
		/// Saves the graphs at the specified directory with the graph label as the file name.
		/// </summary>
		/// <param name="graphs">The <see cref="IGraph">graphs</see> that are being saved.</param>
		/// <param name="directory">The directory the files are saved in.</param>
		/// <returns>True if save was successful.</returns>
		public static bool SaveGraph(IEnumerable<IGraph> graphs, string directory)
		{
			bool rv = true;

			foreach (IGraph graph in graphs)
			{
				rv &= SaveGraph(graph, directory);
			}

			return rv;
		}

		/// <summary>
		/// Saves the graphs at the specified directory with the base name and appended number as the name.
		/// </summary>
		/// <param name="graphs">The <see cref="IGraph">graphs</see> that are being saved.</param>
		/// <param name="directory">The directory the files are saved in.</param>
		/// <param name="baseFileName">The base name of the files to be saved.</param>
		/// <returns>True if save was successful.</returns>
		public static bool SaveGraph(IEnumerable<IGraph> graphs, string directory, string baseFileName)
		{
			bool rv = true;
			int count = 0;

			foreach (IGraph graph in graphs)
			{
				rv &= SaveGraph(graph, directory, baseFileName + (++count).ToString());
			}

			return rv;
		}
	}
}
