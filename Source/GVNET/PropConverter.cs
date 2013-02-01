using System.Reflection;
using System.Drawing;
using System;

namespace GVNET
{
	internal static class PropConverter
	{
		internal static string GetPropValue(PropertyInfo property, object target)
		{
			string rv = string.Empty;

			if (property.PropertyType == typeof(string))
			{
				rv = property.GetValue(target, null).ToString();
			}
			else if (property.PropertyType == typeof(double))
			{
				rv = property.GetValue(target, null).ToString();
			}
			else if (property.PropertyType == typeof(bool))
			{
				rv = property.GetValue(target, null).ToString();
			}
			else if (property.PropertyType == typeof(Color))
			{
				Color myColor = (Color)property.GetValue(target, null);
				rv = GetRGBString(myColor);
			}
			else if (property.PropertyType == typeof(Font))
			{
				Font myFont = (Font)property.GetValue(target, null);
				rv = myFont.Name;
			}
			else if (property.PropertyType == typeof(Shape))
			{
				Shape myShape = (Shape)property.GetValue(target, null);

				if (myShape != Shape.none)
					rv = myShape.ToString();
			}
			else if (property.PropertyType == typeof(NodeStyle))
			{
				NodeStyle myStyle = (NodeStyle)property.GetValue(target, null);

				if (myStyle != NodeStyle.none)
					rv = myStyle.ToString();
			}
			else if (property.PropertyType == typeof(BorderStyle))
			{
				BorderStyle myStyle = (BorderStyle)property.GetValue(target, null);

				if (myStyle != BorderStyle.none)
					rv = myStyle.ToString();
			}
			else if (property.PropertyType == typeof(EdgeStyle))
			{
				EdgeStyle myStyle = (EdgeStyle)property.GetValue(target, null);

				if (myStyle != EdgeStyle.none)
					rv = myStyle.ToString();
			}
			else if (property.PropertyType == typeof(LabelPosition))
			{
				LabelPosition myPosition = (LabelPosition)property.GetValue(target, null);

				switch (myPosition)
				{
					case LabelPosition.top:
						rv = "t";
						break;
					case LabelPosition.center:
						rv = "c";
						break;
					case LabelPosition.bottom:
						rv = "b";
						break;
				}
			}
			else if (property.PropertyType == typeof(ArrowType))
			{
				ArrowType myArrow = (ArrowType)property.GetValue(target, null);

				if (myArrow != ArrowType.none)
					rv = myArrow.ToString();
			}
			else if (property.PropertyType == typeof(DirType))
			{
				DirType myDir = (DirType)property.GetValue(target, null);

				if (myDir != DirType.none)
					rv = myDir.ToString();
			}
			else if (property.PropertyType == typeof(RankDirection))
			{
				RankDirection myDir = (RankDirection)property.GetValue(target, null);

				switch (myDir)
				{
					case RankDirection.TopToBottom:
						rv = "TB";
						break;
					case RankDirection.BottomToTop:
						rv = "BT";
						break;
					case RankDirection.LeftToRight:
						rv = "LR";
						break;
					case RankDirection.RightToLeft:
						rv = "RL";
						break;
				}
			}
			else if (property.PropertyType == typeof(TitlePosition))
			{
				TitlePosition myPos = (TitlePosition)property.GetValue(target, null);

				switch (myPos)
				{
					case TitlePosition.Top:
						rv = "t";
						break;
					case TitlePosition.Bottom:
						rv = "b";
						break;
				}
			}
			else
			{
				throw new InvalidOperationException("Unexpected property type encountered!");
			}

			return rv;
		}

		private static string GetRGBString(Color myColor)
		{
			string rv = "#";

			rv += myColor.R.ToString("X2");
			rv += myColor.G.ToString("X2");
			rv += myColor.B.ToString("X2");

			return rv;
		}
	}
}
