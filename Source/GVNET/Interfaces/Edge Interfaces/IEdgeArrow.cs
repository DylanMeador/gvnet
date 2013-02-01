namespace GVNET
{
	/// <summary>
	/// Base edge with greater arrow control.
	/// </summary>
	public interface IEdgeArrow : IEdge
	{
		/// <summary>
		/// Indicates the type of edge to be drawn by setting which ends draw arrow heads.
		/// </summary>
		[DOTKeyword("dir")]
		DirType Direction { get; }

		/// <summary>
		/// Style of arrowhead on the head node of an edge.
		/// </summary>
		[DOTKeyword("arrowhead")]
		ArrowType ArrowHead { get; }

		/// <summary>
		/// Style of arrowhead on the tail node of an edge.
		/// </summary>
		[DOTKeyword("arrowtail")]
		ArrowType ArrowTail { get; }

		/// <summary>
		/// Multiplicative scale factor for arrow heads.
		/// </summary>
		[DOTKeyword("arrowsize")]
		double ArrowSize { get; }
	}
}
