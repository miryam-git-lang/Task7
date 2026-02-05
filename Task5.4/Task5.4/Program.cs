static bool numberCheck(int number)
{
	for(int i = 2; i < number; i++)
	{
		if (number % i == 0)
		{
			return false;
		}

	}

	return true;
	
}

int number = 8;

Console.WriteLine(numberCheck(number));