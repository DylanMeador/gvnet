using System;
using System.Collections.Generic;
using System.Text;

namespace GVNET
{
	/// <summary>
	/// Basic graph that providers greater control over the edges.
	/// </summary>
	public interface IGraphEdgeControl : IGraph
	{
		/// <summary>
		/// If true, use edge concentrators. This merges multiedges into a single edge and causes partially parallel edges to share part of their paths.
		/// </summary>
		[DOTKeyword("concentrate")]
		bool Concentrate { get; }	/* Dot.exe Only! */

		/// <summary>
		/// Minimum space between two adjacent nodes in the same rank, in inches.
		/// Default is 0.25, minimum is 0.02.
		/// </summary>
		[DOTKeyword("nodesep")]
		double NodeSeparation { get; }

		/// <summary>
		/// If true, splines are used to draw all edges, otherwise, edges are drawn with line segments.
		/// </summary>
		[DOTKeyword("splines")]
		bool Splines { get; }
	}
}
