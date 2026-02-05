static int oddNumbers(int n, int m)
{
	int sum = 0;
	for (int i = n; i < m; i++)
	{
		if (i % 2 != 0)
		{
			sum += i;
		}
	}

	return sum;
}

int n = 10;
int m = 14;

Console.WriteLine(oddNumbers(n, m));