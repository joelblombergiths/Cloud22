/* -- ID 1
//int sum = 0;

//for (int i = 0; i < 1000; i++)
//{
//    if(i % 3 == 0 || i % 5 == 0)
//    {
//        sum += i;
//    }
//}

//Console.WriteLine(sum);
*/

/* -- ID 2
//ulong a = 0;
//ulong b = 1;
//ulong fib;

//ulong sum = 0;


//do
//{
//    fib = a + b;

//    if (fib % 2 == 0) sum += fib;

//    a = b;
//    b = fib;
//}
//while (b < 4000000);

//Console.WriteLine(sum);
*/

/*-- ID 3*/

do
{
	doit();
	Console.ReadKey();
} while (true);

void doit()
{
	Console.WriteLine("Enter number:");
	int number = int.Parse(Console.ReadLine());

	string primeFactors = string.Join(" , ", GetAllPrimeFactors(number));
	Console.WriteLine(primeFactors);
}

List<int> GetAllPrimeFactors(int number)
{
	List<int> primeFactors = new();

	int temp = number;
	foreach (int prime in GetAllPrimeNumbers(number))
	{
		if (temp % prime == 0)
		{
			temp /= prime;
			primeFactors.Add(prime);
		}

		if (IsPrime(temp))
		{
			primeFactors.Add(temp);
			break;
		}
	}

	return primeFactors;
}

List<int> GetAllPrimeNumbers(int max)
{
    List<int> primeNumbers = new();
    for (int i = 2; i < max; i++)
    {
        if (IsPrime(i)) primeNumbers.Add(i);
    }

	return primeNumbers;
}


bool IsPrime(int number)
{
	bool isPrimeNumber = true;

	for (int i = 2; i < number; i++)
	{
		for (int j = 2; j <= i; j++)
		{
			if (number % j == 0) isPrimeNumber = false;
		}
	}

	return isPrimeNumber;
}


/**/

/*-- ID 5
//string s = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

//ulong highestProduct = 0;
//string highestNumberPart = string.Empty;

//for (int i = 0; i < s.Length - 13; i++)
//{
//	string currentNumberPart = s.Substring(i,13);

//    ulong currentProduct = Product(currentNumberPart);

//	if(currentProduct > highestProduct)
//	{
//		highestProduct = currentProduct;
//		highestNumberPart = currentNumberPart;
//	}
//}

//Console.Write(string.Join(" * ", highestNumberPart.ToArray()));
//Console.WriteLine($" = {highestProduct}");

//ulong Product(string part)
//{
//	ulong product = 1;
//	for (int i = 0; i < part.Length; i++)
//	{
//		product *= Convert.ToUInt64(int.Parse(part[i].ToString()));
//	}
//	return product;
//}
*/

/* -- ID 6
//double sumOfSquares = 0;
//int sums = 0;
//for (int i = 1; i <= 100; i++)
//{
//    sumOfSquares += Math.Pow(i, 2);
//    sums += i;
//}

//double squaresOfSum = Math.Pow(sums, 2);

//Console.WriteLine(squaresOfSum - sumOfSquares);
*/

/* -- ID 8
//int number = 0;

//int count;

//do
//{
//	number++;
//	count = 0;

//	for (int i = 1; i <= 20; i++)
//	{
//		if (number % i == 0) count++;
//		else break;
//	}
//}
//while (count < 20);

//Console.WriteLine(number);
*/