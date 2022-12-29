namespace The_first_project
{class Program	

	{
		static void Main(string[] args)

		{
			int first_number, last_number, K, n;
			Console.WriteLine("Please enter the first number");
			first_number = int.Parse(Console.ReadLine());
			Console.WriteLine("Please entre the last number");
			last_number = int.Parse(Console.ReadLine());

			for (n = first_number; n <= last_number; n++)
			{
				K = 1;
				for (int i = 2; i <= n / 2; i++)
				{

					if (n % i == 0)

						K = 0;

					break;
				}
				if (K == 1)
					Console.WriteLine(n);



			}

		}

		 } 
	}
