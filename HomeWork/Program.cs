//________________________ N1 ________________________
//________________________ դ ________________________
//int[,] arr = new int[3, 3];
//arr[0, 0] = 1;
//arr[0, 1] = 5;
//arr[0, 2] = 5;
//arr[1, 0] = 1;
//arr[1, 1] = 5;
//arr[1, 2] = 2;
//arr[2, 0] = 1;
//arr[2, 1] = 1;
//arr[2, 2] = 9;
//for (int i = 0; i < 3; i++)
//{
//    bool isFive = false;
//    int sum = 0;
//    for (int j = 0; j < 3; j++)
//    {
//        if (arr[i, j] == 5)
//        {
//            isFive = true;
//        }
//        sum += arr[i, j];
//    }

//    if (isFive)
//    {
//        Console.WriteLine(sum);
//    }
//}

//________________________ ե ________________________
//int[,] arr = new int[3, 3];
//arr[0, 0] = 7;
//arr[0, 1] = 7;
//arr[0, 2] = 6;
//arr[1, 0] = 3;
//arr[1, 1] = 3;
//arr[1, 2] = 7;
//arr[2, 0] = 2;
//arr[2, 1] = 1;
//arr[2, 2] = 9;
//for (int i = 0; i < 3; i++)
//{
//    bool digit = true;
//    int sum = 0;
//    for (int j = 0; j < 3; j++)
//    {
//        if (arr[i, j] <= 5)
//        {
//            digit = false;
//            break;
//        }
//        sum += arr[i, j];
//    }
//    if (digit)
//    {
//        Console.WriteLine(sum);
//    }
//}

//________________________ զ ________________________
//int[,] arr = new int[3, 3];
//arr[0, 0] = 7;
//arr[0, 1] = 7;
//arr[0, 2] = 6;
//arr[1, 0] = 3;
//arr[1, 1] = 2;
//arr[1, 2] = 2;
//arr[2, 0] = 2;
//arr[2, 1] = 1;
//arr[2, 2] = 9;
//int sum;
//int countPrimes;
//int count = 0;
//for (int i = 0; i < 3; i++)
//{
//    sum = 0;
//    countPrimes = 0;
//    for (int j = 0; j < 3; j++)
//    {
//        sum += arr[i, j];
//        if (IsPrime(sum))
//        {
//            countPrimes++;
//        }
//    }
//    if (countPrimes == 1)
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);

//bool IsPrime(int number)
//{
//    if (number <= 1)
//    {
//        return false;
//    }
//    for (int i = 2; i <= number / 2; i++)
//    {
//        if (number % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}


//________________________ N2 ________________________
//________________________ ա ________________________
//int[,] arr = new int[3, 3];
//arr[0, 0] = 7;
//arr[0, 1] = 7;
//arr[0, 2] = 6;
//arr[1, 0] = 3;
//arr[1, 1] = 2;
//arr[1, 2] = 2;
//arr[2, 0] = 2;
//arr[2, 1] = 1;
//arr[2, 2] = 9;

//int sum = 0;
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        sum += arr[i, j];
//    }
//}

//Console.WriteLine(sum);

//________________________ բ ________________________
//int[,] arr = new int[3, 3];
//arr[0, 0] = 7;
//arr[0, 1] = 7;
//arr[0, 2] = 6;
//arr[1, 0] = 3;
//arr[1, 1] = 2;
//arr[1, 2] = 2;
//arr[2, 0] = 6;
//arr[2, 1] = 7;
//arr[2, 2] = 9;

//int count = 0;

//for (int i = 0; i < 3; i++)
//{
//    bool bigFive = true;

//    for (int j = 0; j < 3; j++)
//    {
//        if (arr[i, j] <= 5)
//        {
//            bigFive = false;
//            break;
//        }
//    }
//    if (bigFive)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

