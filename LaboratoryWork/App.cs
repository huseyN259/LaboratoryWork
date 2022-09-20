static class App
{
	public static void Start()
	{
		Console.ForegroundColor = ConsoleColor.Blue;

		Console.WriteLine("\t\t===== FLASH =====");
		Flash f1 = new Flash { MediaName = "Flash", Model = " Flash Model", Memory = 32, Speed = 300 };
		f1.Copy();
		Console.WriteLine($"Free Memory : {f1.FreeMemoryMethod()} mb");
		f1.PrintDeviceInfo();
		Console.WriteLine();
		Thread.Sleep(1500);

		Console.WriteLine("\t\t===== DVD =====");
		DVD d1 = new DVD { MediaName = "DVD", Model = "DVD Model", Memory = 16, Speed = 9.6 };
		d1.Copy();
		Console.WriteLine($"Free Memory : {d1.FreeMemoryMethod()} mb");
		d1.PrintDeviceInfo();
		Console.WriteLine();
		Thread.Sleep(1500);

		Console.WriteLine("\t\t===== HDD =====");
		HDD h1 = new HDD { MediaName = "HDD", Model = "HDD Model", Memory = 512, Speed = 150 };
		h1.Copy();
		Console.WriteLine($"Free memory : {h1.FreeMemoryMethod()} mb");
		h1.PrintDeviceInfo();
	}
}