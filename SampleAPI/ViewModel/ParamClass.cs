using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAPI.ViewModel
{

    public class NewParam {

        public ParamClassViewModel ParamA { get; set; }
        public ParamClassV2 ParamB { get; set; }


    }

    public class ParamClassViewModel
    {
        public int Seq { get; set; }
        public string Name { get; set; }
        public List<ItemsViewModel> Items { get; set; }
    }

    public class ParamClassV2
    {
        public int ProdId { get; set; }
        public int NewQty { get; set; }

    }

    public class ItemsViewModel
    {
        public int ProdId { get; set; }
        public int Qty { get; set; }

    }
}