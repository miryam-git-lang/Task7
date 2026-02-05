static string deleteSpace(string text)
{
	string newText = "";
	char space = ' ';

	for (int i = 0;	i < text.Length; i++)

		if (text[i] != space)
		{
			newText += text[i];
		}

	return newText;
}

string text = "hi how are you";

Console.WriteLine(deleteSpace(text));