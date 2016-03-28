using System;
using System.Collections.Generic;
using System.Text;

namespace Example01
{
	class Program
	{
		class Class1
		{
			public static String staticStr = "Class";
			public String notstaticStr = "Obj";
		}
		static void Main(string[] args)
		{
			Console.WriteLine ("Class1's staticStr: {0}", Class1.staticStr);

			Class1 tmpObj1 = new Class1 ();
			tmpObj1.notstaticStr = "tmpObj1";
			Class1 tmpObj2 = new Class1 ();
			tmpObj2.notstaticStr = "tmpObj2";

			Console.WriteLine ("tmpObj1's notstaticStr: {0}", tmpObj1.notstaticStr);
			Console.WriteLine ("tmpObj2's notstaticStr: {0}", tmpObj2.notstaticStr);

			Console.ReadLine ();
		}
	}
}

//Class1's staticStr: Class
//tmpObj1's notstaticStr: tmpObj1
//tmpObj2's notstaticStr: tmpObj2
