using System.Drawing;

namespace GVNET
{
	/// <summary>
	/// Contains all the general attributes that can be used in graphs, edges, and nodes.
	/// </summary>
	public interface IFontScheme
	{
		/// <summary>
		/// Color used for text. Default is black.
		/// </summary>
		[DOTKeyword("fontcolor")]
		Color FontColor { get; }

		/// <summary>
		/// The font of for text. Default is Times-Roman.
		/// </summary>
		[DOTKeyword("fontname")]
		Font FontName { get; }

		/// <summary>
		/// Size of font. Default is 14.0, minimum is 1.0.
		/// </summary>
		[DOTKeyword("fontsize")]
		double FontSize { get; }
	}
}
