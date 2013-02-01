using System;
using System.Collections.Generic;
using System.Text;

namespace GVNET
{
	/// <summary>
	/// Basic graph with greater control over how the graph is laid out.
	/// </summary>
	public interface IGraphLayout : IGraph
	{
		/// <summary>
		/// True centers the graph on the canvas.
		/// </summary>
		[DOTKeyword("center")]
		bool Center { get; }

		/// <summary>
		/// Causes the final layout to be rotated counter-clockwise by the specified number of degrees.
		/// </summary>
		[DOTKeyword("rotation")]
		double Rotation { get; }
	}
}
