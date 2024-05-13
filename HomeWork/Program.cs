using HomeWork;

Class1 ob = new Class1();

int[] arr1 = { 2, 5, 3 };
int[] arr2 = { 1, 4, 6 };

List<int> list = ob.Merge(arr1, arr2);

foreach (int i in list)
{
    Console.WriteLine(i);
}
