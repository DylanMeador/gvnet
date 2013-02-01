namespace GVNET
{
	/// <summary>
	/// Determines where in the node the label is located.
	/// </summary>
	public enum LabelPosition
	{
		top, center, bottom
	}

	/// <summary>
	/// Visit <see href="http://www.graphviz.org/content/node-shapes">here</see> to preview each node shape.
	/// </summary>
	public enum Shape
	{
		box, polygon, ellipse, oval, circle, point, egg, triangle, plaintext, diamond, trapezium, parallelogram,
		house, pentagon, hexagon, septagon, octagon, doublecircle, doubleoctagon, tripleoctagon, invtriangle,
		invtrapezium, invhouse, Mdiamond, Msqaure, Mcircle, rectangle, square, none, note, tab, folder, box3d, component
	}

	/// <summary>
	/// The style that effects how the node is rendered.
	/// </summary>
	public enum NodeStyle
	{
		none, filled, diagonals, rounded, invis
	}

	/// <summary>
	/// The style that effects how the border of the node is rendered.
	/// </summary>
	public enum BorderStyle
	{
		none, dashed, dotted, solid, bold
	}
}
