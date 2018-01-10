using System.Collections.Generic;
using DG.Tweening;

namespace FairyGUI
{
    /// <summary>
    /// 元素类型
    /// </summary>
    class FieldTypes
    {
        /// <summary>
        /// 根据值解析包中的元素类型
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static PackageItemType ParsePackageItemType(string value)
        {
            switch (value)
            {
                case "image":
                    return PackageItemType.Image;
                case "movieclip":
                    return PackageItemType.MovieClip;
                case "component":
                    return PackageItemType.Component;
                case "atlas":
                    return PackageItemType.Atlas;
                case "sound":
                    return PackageItemType.Sound;
                case "font":
                    return PackageItemType.Font;
                case "misc":
                    return PackageItemType.Misc;
                default:
                    return PackageItemType.Misc;
            }
        }

        /// <summary>
        /// 根据值解析水平对齐方式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static AlignType ParseAlign(string value)
        {
            switch (value)
            {
                case "left":
                    return AlignType.Left;
                case "center":
                    return AlignType.Center;
                case "right":
                    return AlignType.Right;
                default:
                    return AlignType.Left;
            }
        }
        /// <summary>
        /// 根据值解析垂直对齐方式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static VertAlignType ParseVerticalAlign(string value)
        {
            switch (value)
            {
                case "top":
                    return VertAlignType.Top;
                case "middle":
                    return VertAlignType.Middle;
                case "bottom":
                    return VertAlignType.Bottom;
                default:
                    return VertAlignType.Top;
            }
        }

        /// <summary>
        /// 根据值解析滚动方式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ScrollType ParseScrollType(string value)
        {
            switch (value)
            {
                case "horizontal":
                    return ScrollType.Horizontal;
                case "vertical":
                    return ScrollType.Vertical;
                case "both":
                    return ScrollType.Both;
                default:
                    return ScrollType.Horizontal;
            }
        }
        /// <summary>
        /// 根据值解析滚动条的滚动方式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ScrollBarDisplayType ParseScrollBarDisplayType(string value)
        {
            switch (value)
            {
                case "default":
                    return ScrollBarDisplayType.Default;
                case "visible":
                    return ScrollBarDisplayType.Visible;
                case "auto":
                    return ScrollBarDisplayType.Auto;
                case "hidden":
                    return ScrollBarDisplayType.Hidden;
                default:
                    return ScrollBarDisplayType.Default;
            }
        }
        /// <summary>
        /// 根据值解析溢出显示方式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OverflowType ParseOverflowType(string value)
        {
            switch (value)
            {
                case "visible":
                    return OverflowType.Visible;
                case "hidden":
                    return OverflowType.Hidden;
                case "scroll":
                    return OverflowType.Scroll;
                default:
                    return OverflowType.Visible;
            }
        }

        /// <summary>
        /// 根据值解析填充方式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static FillType ParseFillType(string value)
        {
            switch (value)
            {
                case "none":
                    return FillType.None;
                case "scale":
                    return FillType.Scale;
                case "scaleMatchHeight":
                    return FillType.ScaleMatchHeight;
                case "scaleMatchWidth":
                    return FillType.ScaleMatchWidth;
                case "scaleFree":
                    return FillType.ScaleFree;
                default:
                    return FillType.None;
            }
        }

        /// <summary>
        /// 根据值解析自动大小方式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static AutoSizeType ParseAutoSizeType(string value)
        {
            switch (value)
            {
                case "none":
                    return AutoSizeType.None;
                case "both":
                    return AutoSizeType.Both;
                case "height":
                    return AutoSizeType.Height;
                case "shrink":
                    return AutoSizeType.Shrink;
                default:
                    return AutoSizeType.None;
            }
        }

        /// <summary>
        /// 根据值解析列表布局方式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ListLayoutType ParseListLayoutType(string value)
        {
            switch (value)
            {
                case "column":
                    return ListLayoutType.SingleColumn;
                case "row":
                    return ListLayoutType.SingleRow;
                case "flow_hz":
                    return ListLayoutType.FlowHorizontal;
                case "flow_vt":
                    return ListLayoutType.FlowVertical;
                case "pagination":
                    return ListLayoutType.Pagination;
                default:
                    return ListLayoutType.SingleColumn;
            }
        }
        /// <summary>
        /// 根据值解析列表选择模式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ListSelectionMode ParseListSelectionMode(string value)
        {
            switch (value)
            {
                case "single":
                    return ListSelectionMode.Single;
                case "multiple":
                    return ListSelectionMode.Multiple;
                case "multipleSingleClick":
                    return ListSelectionMode.Multiple_SingleClick;
                case "none":
                    return ListSelectionMode.None;
                default:
                    return ListSelectionMode.Single;
            }
        }

        /// <summary>
        /// 根据值解析进度条标题显示方式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ProgressTitleType ParseProgressTitleType(string value)
        {
            switch (value)
            {
                case "percent":
                    return ProgressTitleType.Percent;
                case "valueAndmax":
                    return ProgressTitleType.ValueAndMax;
                case "value":
                    return ProgressTitleType.Value;
                case "max":
                    return ProgressTitleType.Max;
                default:
                    return ProgressTitleType.Percent;
            }
        }

        /// <summary>
        /// 根据值解析按钮扩展模式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ButtonMode ParseButtonMode(string value)
        {
            switch (value)
            {
                case "Common":
                    return ButtonMode.Common;
                case "Check":
                    return ButtonMode.Check;
                case "Radio":
                    return ButtonMode.Radio;
                default:
                    return ButtonMode.Common;
            }
        }

        /// <summary>
        /// 根据值解析翻转方式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static FlipType ParseFlipType(string value)
        {
            switch (value)
            {
                case "both":
                    return FlipType.Both;
                case "hz":
                    return FlipType.Horizontal;
                case "vt":
                    return FlipType.Vertical;
                default:
                    return FlipType.None;
            }
        }

        /// <summary>
        /// 根据值解析填充方式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static FillMethod ParseFillMethod(string value)
        {
            switch (value)
            {
                case "none":
                    return FillMethod.None;
                case "hz":
                    return FillMethod.Horizontal;
                case "vt":
                    return FillMethod.Vertical;
                case "radial90":
                    return FillMethod.Radial90;
                case "radial180":
                    return FillMethod.Radial180;
                case "radial360":
                    return FillMethod.Radial360;
                default:
                    return FillMethod.None;
            }
        }

        static Dictionary<string, Ease> EaseTypeMap = new Dictionary<string, Ease>
			{
				{ "Linear", Ease.Linear },
				{ "Elastic.In", Ease.InElastic },
				{ "Elastic.Out", Ease.InOutElastic },
				{ "Elastic.InOut", Ease.InOutElastic },
				{ "Quad.In", Ease.InQuad },
				{ "Quad.Out", Ease.OutQuad },
				{ "Quad.InOut", Ease.InOutQuad },
				{ "Cube.In", Ease.InCubic },
				{ "Cube.Out", Ease.OutCubic },
				{ "Cube.InOut", Ease.InOutCubic },
				{ "Quart.In", Ease.InQuart },
				{ "Quart.Out", Ease.OutQuart },
				{ "Quart.InOut", Ease.InOutQuart },
				{ "Quint.In", Ease.InQuint },
				{ "Quint.Out", Ease.OutQuint },
				{ "Quint.InOut", Ease.InOutQuint },
				{ "Sine.In", Ease.InSine },
				{ "Sine.Out", Ease.OutSine },
				{ "Sine.InOut", Ease.InOutSine },
				{ "Bounce.In", Ease.InBounce },
				{ "Bounce.Out", Ease.OutBounce },
				{ "Bounce.InOut", Ease.InOutBounce },
				{ "Circ.In", Ease.InCirc },
				{ "Circ.Out", Ease.OutCirc },
				{ "Circ.InOut", Ease.InOutCirc },
				{ "Expo.In", Ease.InExpo },
				{ "Expo.Out", Ease.OutExpo },
				{ "Expo.InOut", Ease.InOutExpo },
				{ "Back.In", Ease.InBack },
				{ "Back.Out", Ease.OutBack },
				{ "Back.InOut", Ease.InOutBack }
			};
        public static Ease ParseEaseType(string value)
        {
            Ease type;
            if (!EaseTypeMap.TryGetValue(value, out type))
                type = Ease.OutExpo;

            return type;
        }

        /// <summary>
        /// 根据值解析动效变化类型
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TransitionActionType ParseTransitionActionType(string value)
        {
            switch (value)
            {
                case "XY":
                    return TransitionActionType.XY;
                case "Size":
                    return TransitionActionType.Size;
                case "Scale":
                    return TransitionActionType.Scale;
                case "Pivot":
                    return TransitionActionType.Pivot;
                case "Alpha":
                    return TransitionActionType.Alpha;
                case "Rotation":
                    return TransitionActionType.Rotation;
                case "Color":
                    return TransitionActionType.Color;
                case "Animation":
                    return TransitionActionType.Animation;
                case "Visible":
                    return TransitionActionType.Visible;
                case "Sound":
                    return TransitionActionType.Sound;
                case "Transition":
                    return TransitionActionType.Transition;
                case "Shake":
                    return TransitionActionType.Shake;
                case "ColorFilter":
                    return TransitionActionType.ColorFilter;
                case "Skew":
                    return TransitionActionType.Skew;
                default:
                    return TransitionActionType.Unknown;
            }
        }

        /// <summary>
        /// 根据值解析混合类型
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static BlendMode ParseBlendMode(string value)
        {
            switch (value)
            {
                case "add":
                    return BlendMode.Add;

                case "multiply":
                    return BlendMode.Multiply;

                case "none":
                    return BlendMode.None;

                case "screen":
                    return BlendMode.Screen;

                case "erase":
                    return BlendMode.Erase;

                default:
                    return BlendMode.Normal;
            }
        }

        /// <summary>
        /// 根据值解析列表的渲染顺序模式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ChildrenRenderOrder ParseChildrenRenderOrder(string value)
        {
            switch (value)
            {
                case "ascent":
                    return ChildrenRenderOrder.Ascent;

                case "descent":
                    return ChildrenRenderOrder.Descent;

                case "arch":
                    return ChildrenRenderOrder.Arch;

                default:
                    return ChildrenRenderOrder.Ascent;
            }
        }

        /// <summary>
        /// 根据值解析组的布局方式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static GroupLayoutType ParseGroupLayoutType(string value)
        {
            switch (value)
            {
                case "hz":
                    return GroupLayoutType.Horizontal;
                case "vt":
                    return GroupLayoutType.Vertical;
                default:
                    return GroupLayoutType.None;
            }
        }
    }
}
