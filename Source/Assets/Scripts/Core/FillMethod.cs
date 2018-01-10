namespace FairyGUI
{
    /// <summary>
    /// 填充方式
    /// </summary>
    public enum FillMethod
    {
        /// <summary>
        /// 无
        /// </summary>
        None = 0,

        /// <summary>
        /// 水平填充
        /// </summary>
        Horizontal = 1,

        /// <summary>
        /// 垂直填充
        /// </summary>
        Vertical = 2,

        /// <summary>
        /// 从左上角开始进行90 度填充
        /// </summary>
        Radial90 = 3,

        /// <summary>
        /// 从中心顶部开始 180 度填充
        /// </summary>
        Radial180 = 4,

        /// <summary>
        /// 从中心点开始 进行 360 度 填充
        /// </summary>
        Radial360 = 5,
    }
}