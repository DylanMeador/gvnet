namespace GVNET
{

	/// <summary>
	/// Visit <see href="http://www.graphviz.org/content/attrs#karrowType">here</see> to preview each arrow type.
	/// </summary>
	public enum ArrowType
	{
		normal, inverted, dot, invdot, odot, invodot, none, tee, empty, invempty,
		diamond, odiamond, ediamond, crow, box, obox, open, halfopen, vee
	}

	/// <summary>
	/// Determines how the arrow heads are displayed on the edge.
	/// </summary>
	public enum DirType
	{
		forward, backward, both, none
	}

	/// <summary>
	/// Controls how the edge is rendered.
	/// </summary>
	public enum EdgeStyle
	{
		none, dashed, dotted, solid, invis, bold
	}
}
