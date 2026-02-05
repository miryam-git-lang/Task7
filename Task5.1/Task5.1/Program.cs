
static bool divisionCheck(int number)
{
	if (number % 3 == 0 && number % 7 == 0)
	{
		return true;
	}
	 return false;
			
}

int numb = 21;

Console.WriteLine(divisionCheck(numb));