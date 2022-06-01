// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("İçerisinde birden fazla satırlar olabilen, kolon sayısı önceden belirlenmemiş bir tablonun her satırda tek varyasyon olacak şekilde çıktısını verecek algoritma");
Console.WriteLine(" ");

Console.WriteLine("---Dizinin Satır Ve sutun sayılarını giriniz---");
Console.WriteLine(" ");
Console.WriteLine("Dizinin satir sayısını giriniz :");
UInt32 line = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Dizinin sütun sayısını giriniz :");
UInt32 column = Convert.ToUInt32(Console.ReadLine());

HashSet<UInt32> unique = new HashSet<UInt32>();

UInt32[,] arr = new UInt32[line, column];

int j;
int i;
for (i = 0; i < line; i++)
{
    for (j = 0; j < column; j++)
    {
        Console.WriteLine("Dizinin [" + (i + 1) + "] [" + j + "]. index değerini giriniz:");
        arr[i, j] = Convert.ToUInt32(Console.ReadLine());
    }

}
Console.WriteLine(" ");

for (i = 0; i <= arr.GetUpperBound(0); i++)
{
    for (j = 0; j <= arr.GetUpperBound(1); j++)
    {
        if (unique.Add(arr[i, j]))
        {
            Console.Write(" {0} ", arr[i, j]);
        }
        else
        {
            Console.Write("   ");
        }
    }
    Console.WriteLine();

}



Console.Read();
Console.ReadKey();

