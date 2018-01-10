namespace FairyGUI
{
	/*关于BlendMode.Off, 这种模式相当于Blend Off指令的效果。当然，在着色器里使用Blend Off指令可以获得更高的效率，
		但因为Image着色器本身就有多个关键字，复制一个这样的着色器代价太大，所有为了节省Shader数量便增加了这样一种模式，也是可以接受的。
	*/
	
	/// <summary>
	/// 混合模式
	/// </summary>
	public enum BlendMode
	{
        /// <summary>
        /// 正常
        /// </summary>
		Normal,
        /// <summary>
        /// 无
        /// </summary>
		None,
        /// <summary>
        /// 追加
        /// </summary>
		Add,
        /// <summary>
        /// 多个
        /// </summary>
		Multiply,
		Screen,
		Erase,
		Mask,
		Below,
		Off,
		Custom1,
		Custom2,
		Custom3
	}
}
