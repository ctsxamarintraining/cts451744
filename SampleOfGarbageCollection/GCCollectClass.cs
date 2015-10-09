using System;

namespace SampleOfGarbageCollection
{
	public class GCCollectClass
	{
		public GCCollectClass ()
		{
		}
	}
	public class ParentClass
	{
		public string theString;
		public string getString(string s)
		{
			theString = s;
			return theString;
		}
	}
	class ChildClass : ParentClass
	{
		public int theInt = 0;
		public int[] theIntArray = new int[10000];

		public int getInt(int i)
		{
			theInt = i;
			return theInt;
		}


	}
}

