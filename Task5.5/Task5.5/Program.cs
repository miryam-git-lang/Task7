static int SumEvenNumbers(int[] array)
{
	int sum = 0;

	for (int i = 0; i < array.Length; i++)

		if (array[i] % 2 ==0)
		{
			sum += array[i];
		}
	return sum;
}

int[] arr = { 1, 2, 3, 4 };
Console.WriteLine(SumEvenNumbers(arr));