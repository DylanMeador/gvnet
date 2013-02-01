namespace GVNET
{
	/// <summary>
	/// The base node interface.
	/// </summary>
	public interface INode
	{
		/// <summary>
		/// Text label attached to objects.
		/// </summary>
		[DOTKeyword("label")]
		string Label { get; }

		/// <summary>
		/// The outbound edges of the node.
		/// </summary>
		IEdge[] Edges { get; }
	}
}