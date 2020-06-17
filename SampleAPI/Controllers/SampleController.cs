using SampleAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleAPI.Controllers
{
    [RoutePrefix("api/Sample")]
    public class SampleController : ApiController
    {
        
        [HttpPost]
        [Route("ExamplePostData")]
        public IHttpActionResult ExamplePostData(NewParam vm)
        {
            NewMethod(vm.ParamA, vm.ParamB);
            return Ok(vm);
        }

        private static void NewMethod(ParamClassViewModel vm, ParamClassV2 test)
        {
            vm.Items.Add(new ItemsViewModel()
            {
                ProdId = test.ProdId,
                Qty = test.NewQty
            });

        }

        public IHttpActionResult PostNumber(DataTest datanumber , ModelNumber datanumbermodel)
        {
            var DataNumber = new DataTest() { number = datanumber.number, NameNumber = datanumber.NameNumber };
            var DataNumberModel = new ModelNumber() { }; 
            return Ok(DataNumber);
        }
        public IHttpActionResult Get(int id)
        {
            var number = id;
            return Ok(number);
        }
    }


}
