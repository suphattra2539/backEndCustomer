using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAPI.ViewModel
{
    public class DataTest
    {
        public int number { get; set; }
        public string NameNumber { get; set; }
        public List<ModelNumber> Item { get; set; }
    }
    public class ModelNumber
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
    }

}