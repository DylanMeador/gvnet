namespace GVNET
{
	/// <summary>
	/// Basic graph without bare minimum properties.
	/// </summary>
	public interface IGraph
	{
		/// <summary>
		/// The nodes in the directed graph.
		/// </summary>
		INode[] Nodes { get; }

		/// <summary>
		/// The edges in the directed graph.
		/// </summary>
		IEdge[] Edges { get; }

		/// <summary>
		/// Title of the graph.
		/// </summary>
		[DOTKeyword("label")]
		string Label { get; }

		/// <summary>
		/// Indicates if the edge is directed or not
		/// </summary>
		bool Directed { get; }
	}
}
