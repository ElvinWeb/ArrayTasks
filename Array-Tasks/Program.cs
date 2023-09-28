#region ArrayTask
//int[] numbersArr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//double sumEven = 0;
//double sumOdd = 0;
//int countEven = 0;
//int countOdd = 0;

//for (int i = 0; i < numbersArr.Length; i++)
//{
//    if (numbersArr[i] % 2 == 0)
//    {
//        sumEven += numbersArr[i];
//        countEven++;
//    }
//    else
//    {
//        sumOdd += numbersArr[i];
//        countOdd++;
//    }
//}

//double divided = sumOdd / sumEven;

//Console.WriteLine($"arrayin icerisindeki cut ededlerin cemi: {sumEven} , sayi ise {countEven}");
//Console.WriteLine($"arrayin icerisinde tek ededlerin cemi: {sumOdd} , sayi ise {countOdd}");
//Console.WriteLine($"output: {divided}");
#endregion

//verilmis Array
int[] numArr = new int[] { 19, 16, 5, 6, 8, 9 };

//cut ededlerin sayinin tapilmasi
#region ArrayTask-1

//int count = 0;

//for (int i = 0; i < numArr.Length; i++)
//{
//    if (numArr[i] % 2 == 0)
//    {
//        count++;
//    }

//}
//Console.WriteLine($"output: {count}");

#endregion
//cut ededlerin ceminin tapilmasi
#region ArrayTask-2
//int sum = 0;
//for (int i = 0; i < numArr.Length; i++)
//{
//    if (numArr[i] % 2 == 0)
//    {
//        sum += numArr[i];
//    }
//}
//Console.WriteLine($"cüt ededlerin cemi: {sum}");



#endregion
//verilmis n ededinin array icerisindeki her hansisa bir ededden boyuk olub olmamasi
#region ArrayTask-3
//int n = 8;
//bool check = true;

//for (int i = 0; i < numArr.Length; i++)
//{
//    if (numArr[i] < n)
//    {
//        check = false;
//        break;
//    }

//}
//if (check)
//{
//    Console.WriteLine("sehv");
//}
//else
//{
//    Console.WriteLine("dogru");
//}
#endregion
//en cox tekrarlanan elementlerin tapilmasi
#region ArrayTask-4
//int[] customArr = new int[] { 1, 2, 3, 4, 4, 4, 5, 6, 3, 7 };
//int count = 0;
//int maxCount = 0;
//int repNum = 0;

//for (int i = 0; i < customArr.Length; i++)
//{
//    count = 0;

//    for (int j = i + 1; j < customArr.Length; j++)
//    {
//        if (customArr[i] == customArr[j])
//        {
//            count++;
//        }
//    }

//    if (count > maxCount)
//    {
//        maxCount = count;
//        repNum = customArr[i];
//    }
//}

Console.WriteLine(repNum);



#endregion
//tek ededlerin hasilin tapilmasi
#region ArrayTask-5
//int multiply = 1;

//for (int i = 0; i < numArr.Length; i++)
//{
//    if (numArr[i] % 2 == 1)
//    {
//        multiply *= numArr[i];

//    }

//}
//Console.WriteLine($"output: {multiply}");
#endregion
//en boyuk elementin tapilmasi
#region ArrayTask-6
//int maxElement = numArr[0];

//for (int i = 1; i < numArr.Length; i++)
//{
//    if (numArr[i] > maxElement)
//    {
//        maxElement = numArr[i];
//    }
//}
//Console.WriteLine($"output: {maxElement}");

#endregion