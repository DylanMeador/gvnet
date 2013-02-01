using System.Drawing;

namespace GVNET
{
	/// <summary>
	/// Base graph with properties to control color and layout direction.
	/// </summary>
	public interface IGraphSimple : IGraph
	{
		/// <summary>
		/// If true, graph is rendered in landscape mode.
		/// </summary>
		[DOTKeyword("landscape")]
		bool Landscape { get; }

		/// <summary>
		/// Sets the background color for the graph.
		/// </summary>
		[DOTKeyword("bgcolor")]
		Color BackgroundColor { get; }

		/// <summary>
		/// Sets the direction of the graph layout.
		/// </summary>
		[DOTKeyword("rankdir")]
		RankDirection DirectionOfGraph { get; }
	}
}
