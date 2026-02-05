

static int[] numbPowers(int [] numbArr)
{
	int[] newNumbArr = new int[numbArr.Length];

	for (int i = 0; i < numbArr.Length; i++)
	{
		numbArr[i] *= numbArr[i];
		newNumbArr[i] = numbArr[i];

	}

	return newNumbArr;
	
}

int[] nums = {1, 2, 3, 4};
int[] result = numbPowers(nums);

for (int i = 0; i < result.Length; i++)
{
	Console.WriteLine(result[i]);
}




