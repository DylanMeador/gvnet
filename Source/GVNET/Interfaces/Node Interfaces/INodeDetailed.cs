namespace GVNET
{
	/// <summary>
	/// Basic node with greater control on how the node is rendered.
	/// </summary>
	public interface INodeDetailed : INodeSimple
	{
		/// <summary>
		/// The height of the node in inches.
		/// Default is 0.5, minimum is 0.02.
		/// </summary>
		[DOTKeyword("height")]
		double Height { get; }

		/// <summary>
		/// The width of the node in inches.
		/// Default is 0.75, minimum is 0.01.
		/// </summary>
		[DOTKeyword("width")]
		double Width { get; }

		/// <summary>
		/// Gives the name of a file containing an image to be displayed inside a node.
		/// The image file must be in one of the recognized formats: JPEG, PNG, GIF.
		/// </summary>
		[DOTKeyword("image")]
		string Image { get; }

		/// <summary>
		/// This attribute is used only when the height of the node is larger than the height of its label.
		/// It aligns the label with the top, center, or bottom of the node.
		/// </summary>
		[DOTKeyword("labelloc")]
		LabelPosition LabelLocation { get; }

		/// <summary>
		/// Angle, in degrees, used to rotate polygon node shapes. For any number of polygon sides, 0 degrees rotation results in a flat base.
		/// Range is 0.0 to 360.0
		/// </summary>
		[DOTKeyword("orientation")]
		double Orientation { get; }
	}
}
