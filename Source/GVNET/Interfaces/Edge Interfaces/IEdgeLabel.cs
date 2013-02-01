using System.Drawing;

namespace GVNET
{
	/// <summary>
	/// Basic edge with labels on the head and tail of the edge.
	/// </summary>
	public interface IEdgeLabel : IEdge
	{
		/// <summary>
		/// Label to appear on the edge at the head node.
		/// </summary>
		[DOTKeyword("headlabel")]
		string HeadLabel { get; }

		/// <summary>
		/// Label to appear on the edge at the tail node.
		/// </summary>
		[DOTKeyword("taillabel")]
		string TailLabel { get; }

		/// <summary>
		/// Scaled distance for <see cref="HeadLabel"/>/<see cref="TailLabel"/> from <see cref="IEdge.HeadNode"/>/<see cref="IEdge.TailNode"/>. Default is 10.0, minimum is 1.0.
		/// </summary>
		[DOTKeyword("labeldistance")]
		double LabelDistance { get; }

		/// <summary>
		/// The color for the <see cref="HeadLabel"/> and <see cref="TailLabel"/> text. Default is black.
		/// </summary>
		[DOTKeyword("labelfontcolor")]
		Color LabelFontColor { get; }

		/// <summary>
		/// The font for the <see cref="HeadLabel"/> and <see cref="TailLabel"/> text. Default is Times-Roman.
		/// </summary>
		[DOTKeyword("labelfontname")]
		Font LabelFontName { get; }

		/// <summary>
		/// The font size for the <see cref="HeadLabel"/> and <see cref="TailLabel"/> text. Default is 14.0, minimum is 1.0.
		/// </summary>
		[DOTKeyword("labelfontsize")]
		double LabelFontSize { get; }
	}
}
