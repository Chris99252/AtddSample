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
			//throw new NotImplementedException();
			var passwordFromDao = this.ProfileDao.GetPassword(account);
			var hashResult = this.Hash.GetHash(password);

			if (passwordFromDao == hashResult)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public IProfileDao ProfileDao { get; set; }

		public IHash Hash { get; set; }
	}
}
