namespace GVNET
{
	/// <summary>
	/// The base edge interface.
	/// </summary>
	public interface IEdge
	{
		/// <summary>
		/// Text label attached to objects.
		/// </summary>
		[DOTKeyword("label")]
		string Label { get; }

		/// <summary>
		/// The head node of the edge.
		/// </summary>
		INode HeadNode { get; }

		/// <summary>
		/// The tail node of the edge.
		/// </summary>
		INode TailNode { get; }
	}
}
