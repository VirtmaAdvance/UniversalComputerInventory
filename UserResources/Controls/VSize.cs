namespace UniversalComputerInventory.UserResources.Controls
{
	/// <summary>
	/// Provides a struct object for storing data.
	/// </summary>
	/// <remarks>
	/// Creates a new instance of the <see cref="VSize"/> struct.
	/// </remarks>
	/// <param name="width"></param>
	/// <param name="height"></param>
	public struct VSize(double width, double height)
	{
		/// <summary>
		/// The width value.
		/// </summary>
		public double Width { get; set; } = width;
		/// <summary>
		/// The height value.
		/// </summary>
		public double Height { get; set; } = height;


		/// <inheritdoc cref="VSize(double, double)"/>
		public VSize() : this(0, 0) { }

	}
}