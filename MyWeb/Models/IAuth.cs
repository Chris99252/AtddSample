using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWeb.Models
{
	public interface IAuth
	{
		bool Validate(string account, string password);
	}
}
