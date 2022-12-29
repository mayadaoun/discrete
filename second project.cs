using System;
namespace project2
{
	class program
	{
		static void Main(string[] args)
		{
			int first_number, last_number, i, j, sum;
			Console.WriteLine("please,entre the first number");
			first_number = int.Parse(Console.ReadLine());
			Console.WriteLine("please entre the last number ");
			last_number = int.Parse(Console.ReadLine());
			 
			Console.WriteLine("The perfect numbers between {0} and {1} is :" , first_number,last_number );
			for (i = first_number; i <= last_number; i++)
			{
				sum = 0;

				for (j = 1; j < i; j++)
				{
					if (i % j == 0)
					{

						sum += j;
					}
				}

				if (sum == 1)
				{
					Console.WriteLine(i);
				}

			}


		}
	}
}
