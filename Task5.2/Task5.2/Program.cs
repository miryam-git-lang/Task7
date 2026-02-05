
static int oddNumbers (int n, int m)
{
	int count = 0;

	for (int i = n; i < m; i++)
	{
		if(i % 2 != 0)
		{
			count++;
		}
	}

	return count;
}

int n = 10;
int m = 100;

Console.WriteLine(oddNumbers(n, m));