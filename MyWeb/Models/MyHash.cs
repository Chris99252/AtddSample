using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWeb.Models
{
	public class MyHash : IHash
	{
		public string GetHash(string original)
		{
			if (original == "1234")
			{
				return "ooxx";
			}
			else if (original == "abc")
			{
				return "xxxx";
			}

			return "";
		}
	}
}
