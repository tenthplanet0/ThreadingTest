using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadingTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Program ob = new Program();
			ob.StartProgram();
		}

		private void ExecuteProcess1()
		{
			Console.WriteLine("Executing 1!");
		}

		private void ExecuteProcess2()
		{
			Console.WriteLine("Executing 2!");
		}

		private void ExecuteProcess3()
		{
			Console.WriteLine("Executing 3!");
		}

		List<Thread> threads = new List<Thread>();
		private void StartProgram()
		{
			Thread t1 = new Thread(ExecuteProcess1);
			Thread t2 = new Thread(ExecuteProcess2);
			Thread t3 = new Thread(ExecuteProcess3);
			t1.Start();

			t1.Join();
			t2.Start();

			t2.Join();
			t3.Start();

			t3.Join();
		}
	}
}
