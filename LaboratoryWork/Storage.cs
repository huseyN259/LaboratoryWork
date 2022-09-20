abstract class Storage
{
	public string MediaName { get; set; } = default!;
	public string Model { get; set; } = default!;
	protected int FileMemory = 565;
	protected int InFileMemory = 780;
	protected int CountMedia;
	protected double Time;
	protected double FreeMemory;

	public virtual void Copy() { }

	public virtual double FreeMemoryMethod() { return 0; }

	public virtual void PrintDeviceInfo() { }
}