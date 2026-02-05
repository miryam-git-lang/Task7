using static System.Runtime.InteropServices.JavaScript.JSType;

static int[] addToArray(int number)
{
	int[] array = { 1, 5, 8 };
	int[] newArray = new int[array.Length + 1];

	for (int i = 0; i < array.Length; i++)
	{
		newArray[i] = array[i];
		newArray[newArray.Length - 1] = number;
	
	}

	return newArray;
}

int[] result = addToArray(9);
foreach (var item in result)
{
	Console.WriteLine(item);

}