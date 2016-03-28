using System;
using System.Collections.Generic;
using System.Text;

namespace Example02Lib
{
	public class Class1
	{
		public const String strConst = "Const";
		public static readonly String strStaticReadonly = "StaticReadonly";
		//public const String strConst = "Const Changed";
		//public static readonly String strStaticReadonly = "StaticReadonly Changed";
	}
}


namespace Example02Lib
{
    public class Class1
    {
        //public const String strConst = "Const";
        //public static readonly String strStaticReadonly = "StaticReadonly";
        public const String strConst = "Const Changed";
        public static readonly String strStaticReadonly = "StaticReadonly Changed";
    }
}
