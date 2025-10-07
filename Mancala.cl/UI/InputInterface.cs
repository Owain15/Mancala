using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala.cl.UI
{
	public interface InputInterface
	{
		public Mancala.cl.UI.Command GetCommand();
	}
}
