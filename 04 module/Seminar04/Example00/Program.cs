﻿using System;
class A
{
	public int[] ar;
	public A() { ar = new int[3]; }
	public A(A o) { ar = o.ar; }
}
class test_cs
{
	static void Main()
	{
		A obj = new A();
		A obj1 = new A(obj);
		obj.ar[1] = 4;
		obj.ar[0] = obj1.ar[2] = obj.ar.Length;
		foreach (int temp in obj1.ar)
			Console.Write(temp);
		Console.ReadKey();
	}
}