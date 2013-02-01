namespace GVNET
{
	/// <summary>
	/// Basic node that gives control over the node shape if it's a polygon.
	/// </summary>
	public interface INodePolygon : INodeSimple
	{
		/// <summary>
		/// Distortion factor for shape=polygon. Positive values cause top part to be larger than bottom; negative values do the opposite.
		/// Default is 0.0, minimum is -100.0.
		/// </summary>
		[DOTKeyword("distortion")]
		double Distortion { get; }

		/// <summary>
		/// If true, force polygon to be regular, i.e., the vertices of the polygon will lie on a circle whose center is the center of the node.
		/// </summary>
		[DOTKeyword("regular")]
		bool Regular { get; }

		/// <summary>
		/// If the NodeShape=Polygon, this sets the number of sides of that polygon.
		/// Default is 4, minimum is 0.
		/// </summary>
		[DOTKeyword("sides")]
		int Sides { get; }

		/// <summary>
		/// Skew factor for NodeShape=Polygon. Positive values skew top of polygon to right; negative to left.
		/// Default is 0, minimum is -100.0.
		/// </summary>
		[DOTKeyword("skew")]
		double Skew { get; }
	}
}
