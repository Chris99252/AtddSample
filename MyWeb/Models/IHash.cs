using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWeb.Models
{
	public interface IHash
	{
		string GetHash(string original);
	}
}
