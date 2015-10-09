using System;

namespace SampleOfGarbageCollection
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ParentClass p = new ParentClass();
			string s = p.getString ("Hello");
			Console.WriteLine ("String "+s+".");
			ChildClass c = new ChildClass ();
			int a = c.getInt (10);
			Console.WriteLine ("Integer " + a + ".");
			MainClass m = new MainClass ();
			m.GarbageMethod (2000);
			Console.WriteLine ("Before calling GC.Collect() "+ GC.GetTotalMemory(false));
			GC.Collect ();
			Console.WriteLine ("After calling GC.Collect() "+ GC.GetTotalMemory(false));
		}
		public void GarbageMethod(int value)
		{
			ChildClass ch;
			for (int i=0; i < value ; i++)
			{
				ch = new ChildClass ();
			}
		}
	}
}
