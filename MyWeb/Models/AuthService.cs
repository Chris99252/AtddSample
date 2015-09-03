using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWeb.Models
{
	public class AuthService : IAuth
	{
		public bool Validate(string account, string password)
		{
			//if (account == "joeychen" && password == "1234")
			//{				
			//	return true;
			//}
			//else
			//{				
			//	return false;
			//}

			throw new NotImplementedException();
		}

		public IProfileDao ProfileDao { get; set; }

		public IHash Hash { get; set; }
	}
}
