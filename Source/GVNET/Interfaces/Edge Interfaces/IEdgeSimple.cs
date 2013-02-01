using System.Drawing;

namespace GVNET
{
	/// <summary>
	/// Base edge with added control over the styling of the edge.
	/// </summary>
	public interface IEdgeSimple : IEdge
	{		
		/// <summary>
		/// Weight of edge. The heavier the weight, the shorter, straighter and more vertical the edge is.
		/// </summary>
		[DOTKeyword("weight")]
		double Weight { get; }	/* Different minimums for different programs. */

		/// <summary>
		/// Set the style for the edge.
		/// </summary>
		[DOTKeyword("style")]
		EdgeStyle EdgeStyle { get; }

		/// <summary>
		/// The color of the Edge. Default is black.
		/// </summary>
		[DOTKeyword("color")]
		Color EdgeColor { get; }
	}
}
