
bool isActive = true;
while (isActive)
{
    Console.WriteLine("0 - Generate 100 patients");
    Console.WriteLine("1 - Exit");
	
    var key = Console.ReadLine();
    switch (key)
	{
		case "0":
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
