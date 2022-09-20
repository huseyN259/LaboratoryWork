class DVD : Storage
{
	public double Speed; // Mb/s
	public double Memory; // Gb

	public override void Copy()
	{
		double secondTime = 780 / Speed;
		int count = Convert.ToInt32((FileMemory * 1024) / 780);
		Time = count * secondTime;

		CountMedia = Convert.ToInt32(FileMemory / Memory);
		Console.WriteLine($"Count of Media : {CountMedia}");

		if (Time > 3600)
			Console.WriteLine($"Copy Time : {Convert.ToInt32(Time / 3600)} hour");
		else if (Time > 60)
			Console.WriteLine($"Copy Time : {Convert.ToInt32(Time / 60)} minute, {Convert.ToInt32(Time - (Convert.ToInt32(Time / 60) * 60))} second");
	}

	public override double FreeMemoryMethod()
	{
		if ((FileMemory * 1024) > (Memory * CountMedia * 1024))
		{
			FreeMemory = (FileMemory * 1024) - (Memory * CountMedia * 1024);

			return FreeMemory;
		}
		else if ((FileMemory * 1024) < (Memory * CountMedia * 1024))
		{
			FreeMemory = (Memory * CountMedia * 1024) - (FileMemory * 1024);

			return FreeMemory;
		}

		return 0;
	}

	public override void PrintDeviceInfo()
	{
		Console.WriteLine($"Media Name : {MediaName}");
		Console.WriteLine($"ModeL : {Model}");
		Console.WriteLine($"Speed : {Speed} Mb/s");
		Console.WriteLine($"Memory : {Memory} Gb");
	}
}