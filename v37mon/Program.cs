
void uppg74()
{
	bool isValidInput = false;
	int inputNumber = -1;
    do
    {
		try
		{
			Console.WriteLine("Enter number:");
			inputNumber = int.Parse(Console.ReadLine());
			isValidInput = true;
		}
		catch
		{
			Console.WriteLine("Not a valid number.");
		}
	} while (!isValidInput);

	try
	{
		Console.WriteLine(inputNumber / 0);
	}
	catch 
	{
		Console.WriteLine("error");
	}

	Console.WriteLine(inputNumber * 10);
}



uppg74();