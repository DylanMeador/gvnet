namespace GVNET
{
	/// <summary>
	/// Basic graph that allows further control of the title.
	/// </summary>
	public interface IGraphTitle : IGraphFont
	{
		/// <summary>
		/// Places the graph title at either the top or bottom of the canvas.
		/// </summary>
		[DOTKeyword("labelloc")]
		TitlePosition TitleLocation { get; }

		/// <summary>
		/// Height of the graph label in inches.
		/// </summary>
		[DOTKeyword("lheight")]
		double TitleHeight { get; }

		/// <summary>
		/// Width of the graph label in inches.
		/// </summary>
		[DOTKeyword("lwidth")]
		double TitleWidth { get; }
	}
}
