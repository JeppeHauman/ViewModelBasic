using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelBasic
{
    public class KlasseRum
    {
		private string _navn;

		public string Navn
		{
			get { return _navn; }
			set { _navn = value; }
		}

		private int _rumId;

		public int RumId
		{
			get { return _rumId; }
			set { _rumId = value; }
		}



	}
}
