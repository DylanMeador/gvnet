namespace GVNET
{
	/// <summary>
	/// Same functionalities as <see cref="IEdgeDefined"/> with more control over where the edge is attached and the length of the edge.
	/// </summary>
	public interface IEdgeDetailed : IEdgeDefined
	{
		/// <summary>
		/// True: The edge constrains its nodes to be on different ranks
		/// False: The nodes can be on the same rank.
		/// </summary>
		[DOTKeyword("constraint")]
		bool Constraint { get; }	/* Dot.exe only */

		/// <summary>
		/// True: The edge is clipped to the edge of the head node.
		/// False: The end of the edge goes to the center of the head node.
		/// </summary>
		[DOTKeyword("headclip")]
		bool HeadClip { get; }

		/// <summary>
		/// True: The edge is clipped to the edge of the tail node.
		/// False: The end of the edge goes to the center of the tail node.
		/// </summary>
		[DOTKeyword("tailclip")]
		bool TailClip { get; }

		/// <summary>
		/// Minimum edge length (rank difference between head and tail). Default is 1, minimum is 0.
		/// </summary>
		[DOTKeyword("minlen")]
		int MinLength { get; }
	}
}
