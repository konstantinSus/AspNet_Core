using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myProjectApi.ModelsResponse
{
    public class ToyotasResponce {

        public List<ToyotaAuto> Toyota { get; set; }

    }
    public class ToyotaAuto
    {
        public string MarkAuto { get; set; }
        public int NumberAuto { get; set; }
        public int Massa { get; set; }
        public string ClassEuro { get; set; }
    }
}
