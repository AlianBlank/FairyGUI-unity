namespace FairyGUI
{
    /// <summary>
    /// 填充方式
    /// </summary>
    public enum FillType
    {
        /// <summary>
        /// 无
        /// </summary>
        None,
        /// <summary>
        /// 等比缩放（匹配宽度和高度）
        /// </summary>
        Scale,
        /// <summary>
        /// 等比缩放（匹配高度）
        /// </summary>
        ScaleMatchHeight,
        /// <summary>
        /// 等比缩放（匹配宽度）
        /// </summary>
        ScaleMatchWidth,
        /// <summary>
        /// 自由缩放
        /// </summary>
        ScaleFree
    }
}