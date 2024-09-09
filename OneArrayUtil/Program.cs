public static class ArrayUtils
{
	public static void Reverse<T>(T[] array)
	{
		if (array == null || array.Length <= 1)
		{
			throw new ArgumentException("Array cannot be null or empty", nameof(array));
		}

		int left = 0;
		int right = array.Length - 1;

		while (left < right)
		{
			(array[left], array[right]) = (array[right], array[left]);
			left++;
			right--;
		}
	}
}

class Program
{
	static void Main(string[] args)
	{
		int[] numbers = [1, 2, 5, 3];
		ArrayUtils.Reverse(numbers);
		Console.WriteLine(string.Join(", ", numbers));

		string[] words = ["Overwatch", "Банан", "Елемент", "Танки", "NotAGame"];
		ArrayUtils.Reverse(words);
		Console.WriteLine(string.Join(", ", words));
	}
}
