

//static int SumEvenNums (int n , int m)
//{
//    int sum = 0;

//	if (n%2 == 0 && m%2 == 0)
//	{
//		sum = n + m;
//	}

//	return sum;
//}



//int num1 = 10;
//int num2 = 8;

//var result = SumEvenNums (num1, num2);

//Console.WriteLine(result);



//static int SumEvenNums(int n, int m)

//static void SumOddNums (int n, int m)
//{
//    int sum = 0;

//	for (int i = n; i <= m ; i++)
//	{
//		if (i%2 == 1)
//		{
//			sum += i;
//		}
//	}
//	Console.WriteLine(sum);
//}

//SumOddNums(2, 8);



//static int GetCountOfEvenNumsFromArray(int[] nums)
//{
//    int count = 0;

//	foreach (var item in nums)
//	{
//		if (item % 2 == 0)
//		{
//			count++;
//		}
//	}

//	return count;
//}

//int[] arr = { 1, 5, 7, 9, 6, 8, };

//var result = GetCountOfEvenNumsFromArray(arr);

//Console.WriteLine(result);



//static int GetCountOfEvenNumsFromArray(int[] nums)
//{
//    int count = 0;

//	foreach (var item in nums)
//	{
//		if (!NumIsZero(item))
//		{
//			if (IsDivided(item))
//			{
//				count++;
//			}
//		}

//	}
//		return count;
//}

//	static int[] GetArr()
//	{
//		return new int[] { 1, 2, 5, 6, 8, 9, 10 };
//	}

//	static bool IsDivided(int number)
//	{
//		return number % 2 == 0;
//	}

//	static bool NumIsZero(int num)
//	{
//		return num == 0;
//	}
//	int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 0 };

//	var arr1= GetArr();

//	int result =GetCountOfEvenNumsFromArray(arr);
//	Console.WriteLine(result);

#region Heap-stack
//int a = 5;
//int b = a;
//b= a;

//Console.WriteLine(a);
//Console.WriteLine(b);


//int[] arr1 = { 1, 2, 3 };

//int[] arr2 = { 4, 5, 6 };
//int n = 5;

//arr2[0] = arr1[0];

//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1[0]);



//int n = 100;

//Test(out  n);

//Console.WriteLine(n);

//static void Test(out int n)
//{
//    n = 2;
//    Console.WriteLine(n);
//}


//int[] arr = { 2, 3, 4, 5 };

//Test2(arr);

//Console.WriteLine(arr[0]);

//static void Test2(int[] arr)
//{
//    arr[0] = 200;
//    Console.WriteLine(arr[0]);
//}
#endregion



//
//string name = "Pervin";

//string name2 = name;

//Console.WriteLine(name);
//Console.WriteLine(name2);



//string address = "Ehmedli";

//Console.WriteLine(address.Length);

//Console.WriteLine(address.StartsWith("E"));
//Console.WriteLine(address.EndsWith("i"));

//if (address.EndsWith("i"))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}


//if (address.Contains("t")) 
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}


//string address =

//address = "roya";

////Console.WriteLine(address.ToLower());

//for (int i = 0; i < address.Length; i++)
//{

//}
//Console.WriteLine(address[0].ToString().ToUpper());

//Test(ref address);

//Test(ref address);

//Console.WriteLine(address);

//static void Test(ref string str)
//{
//    var res = str[0];
//    res = 'R';
//}



//string address = "roya";

//var letter = address[0].ToString().ToUpper();


//var arr = address.ToCharArray();
//arr[0] = char.Parse(letter);

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}


//string name = "Jale";

//Console.WriteLine(name.Substring(2).ToUpper());


//string name = "Jale";

//string name2 = "Jale";

//Console.WriteLine(name.Substring(2).ToUpper());
//Console.WriteLine(name.Trim());
//Console.WriteLine(name.Trim() == name2);

//Console.WriteLine(name.Replace("J", "T"));

//if (string.IsNullOrWhiteSpace(name))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}