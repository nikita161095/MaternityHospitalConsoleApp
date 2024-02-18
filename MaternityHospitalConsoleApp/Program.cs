
using MaternityHospitalConsoleApp;

Features features = new Features();
bool isActive = true;

while (isActive)
{
    Console.WriteLine("0 - Generate 100 patients");
    Console.WriteLine("1 - Exit");
	
    var key = Console.ReadLine();
    switch (key)
	{
		case "0":
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + 1);
                var res = await features.CreatePatients();
                if (res == null) Console.WriteLine("Exception...");
                else Console.WriteLine(res); Console.WriteLine();
            }
			break;
		case "1":
			isActive = false;
			break;
        default:
            Console.WriteLine();
            Console.WriteLine("Incorrect data");
			break;
	}
    Console.WriteLine();
}
Environment.Exit(0);
