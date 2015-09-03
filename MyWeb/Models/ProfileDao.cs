using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWeb.Models
{
	public class ProfileDao : IProfileDao
	{
		public string GetPassword(string id)
		{
			if (id == "joeychen")
			{
				return "ooxx";
			}

			return "";
		}
	}
}
