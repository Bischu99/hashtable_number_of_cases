
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp1
{
	class Program
	{
		static void printArr(int[] a, int n)
		{
			for (int i = 0; i < n; i++)
				Console.Write(a[i] + " ");
			Console.WriteLine();
		}

		static void heapPermutation(int[] a, int size, int n)
		{
			// if size becomes 1 then prints the obtained
			// permutation
			if (size == 1)
				printArr(a, n);

			for (int i = 0; i < size; i++)
			{
				heapPermutation(a, size - 1, n);

				// if size is odd, swap 0th i.e (first) and
				// (size-1)th i.e (last) element
				if (size % 2 == 1)
				{
					int temp = a[0];
					a[0] = a[size - 1];
					a[size - 1] = temp;
				}

				// If size is even, swap ith and
				// (size-1)th i.e (last) element
				else
				{
					int temp = a[i];
					a[i] = a[size - 1];
					a[size - 1] = temp;
				}
			}
		}

		static void Main(string[] args)
		{
			Hashtable clothes = new Hashtable(); 
			clothes.Add("yellowhat", "headgear");
			clothes.Add("bluesunglasses", "yewear");
			clothes.Add("green_turban", "headgear");
			int answer = 0;
			int cut = 0;
			

			foreach (var i in clothes)
			{
				cut++;
			}
			int[] a = new int[cut];
			for (int i = 0; i < cut; i++)
			{
					a[i] = i;
			}

			heapPermutation(a, a.Length, a.Length);

			Console.WriteLine(cut);


			//foreach (DictionaryEntry cl in clothes)
			//{
			//	if (answer == 0)
			//	{
			//		answer++;
			//	}
			//	else if ()
			//		clothes_set[0] = (string)cl.Key;
			//	Console.WriteLine("Key =  {0}, Value =  {1}", cl.Key, cl.Value);
			//}
			Console.WriteLine("총 조합의 수는  " + answer  + "입니다.");
			return;


		}
		
	}

}
