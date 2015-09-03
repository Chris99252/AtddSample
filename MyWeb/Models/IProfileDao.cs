using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWeb.Models
{
	public interface IProfileDao
	{
		string GetPassword(string id);
	}
}
