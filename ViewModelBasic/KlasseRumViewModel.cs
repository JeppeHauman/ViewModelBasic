using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelBasic
{
    public class KlasseRumViewModel
    {
        public ObservableCollection<KlasseRum> OC_Klasserum
        {
            get
            {
                return new ObservableCollection<KlasseRum>()
                {
                    new KlasseRum() { Navn = "1E", RumId = 1 },
                    new KlasseRum() { Navn = "2E", RumId = 2 },
                    new KlasseRum() { Navn = "3E", RumId = 3 },
                };
            }
        }

    }
}
