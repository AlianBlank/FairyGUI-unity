namespace FairyGUI
{
    /// <summary>
    /// 动效变化类型
    /// </summary>
    public enum TransitionActionType
    {
        /// <summary>
        /// 改变位置
        /// </summary>
        XY,
        /// <summary>
        /// 改变大小
        /// </summary>
        Size,
        /// <summary>
        /// 改变缩放
        /// </summary>
        Scale,
        /// <summary>
        /// 改变轴心
        /// </summary>
        Pivot,
        /// <summary>
        /// 改变透明度
        /// </summary>
        Alpha,
        /// <summary>
        /// 改变旋转
        /// </summary>
        Rotation,
        /// <summary>
        /// 改变颜色
        /// </summary>
        Color,
        /// <summary>
        /// 改变动画
        /// </summary>
        Animation,
        /// <summary>
        /// 可见性
        /// </summary>
        Visible,
        /// <summary>
        /// 播放声音
        /// </summary>
        Sound,
        /// <summary>
        /// 播放动效
        /// </summary>
        Transition,
        /// <summary>
        /// 播放震动
        /// </summary>
        Shake,
        /// <summary>
        /// 改变颜色滤镜
        /// </summary>
        ColorFilter,
        /// <summary>
        /// 改变倾斜
        /// </summary>
        Skew,
        /// <summary>
        /// 无/未知
        /// </summary>
        Unknown
    }
}